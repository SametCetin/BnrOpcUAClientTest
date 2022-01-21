using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BnrOpcUAClientTest
{
    public partial class Form1 : Form
    {

        public Hylasoft.Opc.Ua.UaClient UAClient;
        public string OpcUaPathBR = "PLC.Modules.<Default>.Global PV";

        public Form1()
        {
            InitializeComponent();
        }

        private void txtVarAddr_Click(object sender, EventArgs e)
        {
            (sender as TextBox).SelectAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrCheckServer.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            tmrCheckServer.Stop();
        }

        private void tmrCheckServer_Tick(object sender, EventArgs e)
        {
            tmrCheckServer.Stop();
            System.Threading.Thread threadPlcConn = new System.Threading.Thread(ConnectOpcUAClient)
            {
                IsBackground = true,
                Priority = System.Threading.ThreadPriority.Lowest
            };
            threadPlcConn.Start();
        }

        private void ConnectOpcUAClient()
        {
            if (UAClient == null)
            {
                Uri uri = new Uri("opc.tcp://127.0.0.1:4840");
                UAClient = new Hylasoft.Opc.Ua.UaClient(uri);
            }

            try
            {
                if (UAClient.Status == Hylasoft.Opc.Common.OpcStatus.NotConnected)
                {
                    UAClient.Connect();
                    Invoke(new Action(() => { lblServerStatus.Text = "Not Connected"; }));
                }
                else
                {
                    Invoke(new Action(() => { lblServerStatus.Text = "Connected"; }));
                }
            }
            catch { Invoke(new Action(() => { lblServerStatus.Text = "Not Connected"; })); }

            if (UAClient != null && UAClient.Status == Hylasoft.Opc.Common.OpcStatus.Connected)
                tmrCheckServer.Interval = 4000;
            else
                tmrCheckServer.Interval = 400;

            Invoke(new Action(() => { tmrCheckServer.Start(); }));
        }

        private void btnReadVar_Click(object sender, EventArgs e)
        {
            OpcUaClientComm uacomm = new OpcUaClientComm();
            
            if (txtReadVarType.Text == "bool")
            {
                uacomm.ReadPlc<bool>(UAClient, OpcUaPathBR + txtVarReadAddr.Text, out bool val);
                txtReadVal.Text = val.ToString();
            }
            if (txtReadVarType.Text == "double")
            {
                uacomm.ReadPlc<double>(UAClient, OpcUaPathBR + txtVarReadAddr.Text, out double val);
                txtReadVal.Text = val.ToString();
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            OpcUaClientComm uacomm = new OpcUaClientComm();

            if (txtReadVarType.Text == "bool")
            {
                uacomm.WritePlc<bool>(UAClient, OpcUaPathBR + txtVarReadAddr.Text, Convert.ToBoolean(txtWriteVal.Text));
            }
            if (txtReadVarType.Text == "double")
            {
                uacomm.WritePlc<double>(UAClient, OpcUaPathBR + txtVarReadAddr.Text, Convert.ToDouble(txtWriteVal.Text));
            }
        }
    }
}

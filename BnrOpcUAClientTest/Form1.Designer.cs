
namespace BnrOpcUAClientTest
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnReadVar = new System.Windows.Forms.Button();
            this.txtVarReadAddr = new System.Windows.Forms.TextBox();
            this.txtVarWriteAddr = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnConnToServer = new System.Windows.Forms.Button();
            this.lblServerStatus = new System.Windows.Forms.Label();
            this.tmrCheckServer = new System.Windows.Forms.Timer(this.components);
            this.txtServerAddr = new System.Windows.Forms.TextBox();
            this.txtReadVarType = new System.Windows.Forms.TextBox();
            this.txtWriteVarType = new System.Windows.Forms.TextBox();
            this.txtReadVal = new System.Windows.Forms.TextBox();
            this.txtWriteVal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReadVar
            // 
            this.btnReadVar.Location = new System.Drawing.Point(12, 66);
            this.btnReadVar.Name = "btnReadVar";
            this.btnReadVar.Size = new System.Drawing.Size(75, 23);
            this.btnReadVar.TabIndex = 0;
            this.btnReadVar.Text = "Read";
            this.btnReadVar.UseVisualStyleBackColor = true;
            this.btnReadVar.Click += new System.EventHandler(this.btnReadVar_Click);
            // 
            // txtVarReadAddr
            // 
            this.txtVarReadAddr.Location = new System.Drawing.Point(135, 68);
            this.txtVarReadAddr.Name = "txtVarReadAddr";
            this.txtVarReadAddr.Size = new System.Drawing.Size(190, 20);
            this.txtVarReadAddr.TabIndex = 1;
            this.txtVarReadAddr.Text = "Variable Full Address";
            this.txtVarReadAddr.Click += new System.EventHandler(this.txtVarAddr_Click);
            // 
            // txtVarWriteAddr
            // 
            this.txtVarWriteAddr.Location = new System.Drawing.Point(135, 103);
            this.txtVarWriteAddr.Name = "txtVarWriteAddr";
            this.txtVarWriteAddr.Size = new System.Drawing.Size(190, 20);
            this.txtVarWriteAddr.TabIndex = 3;
            this.txtVarWriteAddr.Text = "Variable Full Address";
            this.txtVarWriteAddr.Click += new System.EventHandler(this.txtVarAddr_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(12, 101);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnConnToServer
            // 
            this.btnConnToServer.Location = new System.Drawing.Point(12, 30);
            this.btnConnToServer.Name = "btnConnToServer";
            this.btnConnToServer.Size = new System.Drawing.Size(106, 23);
            this.btnConnToServer.TabIndex = 4;
            this.btnConnToServer.Text = "Server Addr";
            this.btnConnToServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnToServer.UseVisualStyleBackColor = true;
            // 
            // lblServerStatus
            // 
            this.lblServerStatus.AutoSize = true;
            this.lblServerStatus.Location = new System.Drawing.Point(340, 35);
            this.lblServerStatus.Name = "lblServerStatus";
            this.lblServerStatus.Size = new System.Drawing.Size(69, 13);
            this.lblServerStatus.TabIndex = 5;
            this.lblServerStatus.Text = "Server status";
            // 
            // tmrCheckServer
            // 
            this.tmrCheckServer.Interval = 400;
            this.tmrCheckServer.Tick += new System.EventHandler(this.tmrCheckServer_Tick);
            // 
            // txtServerAddr
            // 
            this.txtServerAddr.Location = new System.Drawing.Point(135, 32);
            this.txtServerAddr.Name = "txtServerAddr";
            this.txtServerAddr.ReadOnly = true;
            this.txtServerAddr.Size = new System.Drawing.Size(190, 20);
            this.txtServerAddr.TabIndex = 6;
            this.txtServerAddr.Text = "opc.tcp://127.0.0.1:4840";
            // 
            // txtReadVarType
            // 
            this.txtReadVarType.Location = new System.Drawing.Point(343, 69);
            this.txtReadVarType.Name = "txtReadVarType";
            this.txtReadVarType.Size = new System.Drawing.Size(113, 20);
            this.txtReadVarType.TabIndex = 7;
            this.txtReadVarType.Text = "Variable Type";
            this.txtReadVarType.Click += new System.EventHandler(this.txtVarAddr_Click);
            // 
            // txtWriteVarType
            // 
            this.txtWriteVarType.Location = new System.Drawing.Point(343, 103);
            this.txtWriteVarType.Name = "txtWriteVarType";
            this.txtWriteVarType.Size = new System.Drawing.Size(113, 20);
            this.txtWriteVarType.TabIndex = 8;
            this.txtWriteVarType.Text = "Variable Type";
            this.txtWriteVarType.Click += new System.EventHandler(this.txtVarAddr_Click);
            // 
            // txtReadVal
            // 
            this.txtReadVal.Location = new System.Drawing.Point(472, 69);
            this.txtReadVal.Name = "txtReadVal";
            this.txtReadVal.ReadOnly = true;
            this.txtReadVal.Size = new System.Drawing.Size(113, 20);
            this.txtReadVal.TabIndex = 9;
            this.txtReadVal.Text = "Value";
            // 
            // txtWriteVal
            // 
            this.txtWriteVal.Location = new System.Drawing.Point(472, 101);
            this.txtWriteVal.Name = "txtWriteVal";
            this.txtWriteVal.Size = new System.Drawing.Size(113, 20);
            this.txtWriteVal.TabIndex = 10;
            this.txtWriteVal.Text = "Value";
            this.txtWriteVal.Click += new System.EventHandler(this.txtVarAddr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtWriteVal);
            this.Controls.Add(this.txtReadVal);
            this.Controls.Add(this.txtWriteVarType);
            this.Controls.Add(this.txtReadVarType);
            this.Controls.Add(this.txtServerAddr);
            this.Controls.Add(this.lblServerStatus);
            this.Controls.Add(this.btnConnToServer);
            this.Controls.Add(this.txtVarWriteAddr);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtVarReadAddr);
            this.Controls.Add(this.btnReadVar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadVar;
        private System.Windows.Forms.TextBox txtVarReadAddr;
        private System.Windows.Forms.TextBox txtVarWriteAddr;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnConnToServer;
        private System.Windows.Forms.Label lblServerStatus;
        private System.Windows.Forms.Timer tmrCheckServer;
        private System.Windows.Forms.TextBox txtServerAddr;
        private System.Windows.Forms.TextBox txtReadVarType;
        private System.Windows.Forms.TextBox txtWriteVarType;
        private System.Windows.Forms.TextBox txtReadVal;
        private System.Windows.Forms.TextBox txtWriteVal;
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hylasoft.Opc.Ua;

namespace BnrOpcUAClientTest
{
    class OpcUaClientComm
    {
        public bool ReadPlc<T>(UaClient uaClient, string varName, out T val)
        {
            if (PlcConnIsOk(uaClient))
            {
                try
                {
                    val = uaClient.Read<T>(varName).Value;
                    return true;
                }
                catch (Exception ex)
                {
                    val = default;
                    return false;
                }
            }
            else
            {
                val = default;
                return false;
            }
        }

        public bool WritePlc<T>(UaClient uaClient, string varName, T val)
        {
            if (PlcConnIsOk(uaClient))
            {
                try
                {
                    uaClient.Write<T>(varName, val);
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool PlcConnIsOk(UaClient uaClient)
        {
            if (uaClient == null)
                return false;

            if (uaClient.Status != Hylasoft.Opc.Common.OpcStatus.Connected)
                return false;


            return true;
        }
    }
}

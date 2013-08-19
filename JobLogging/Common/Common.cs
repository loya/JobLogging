using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace JobLogging.Common
{
    class Common
    {
        public bool CheckIP(string ipAddress)
        {
            Ping pingSender = new Ping();
            PingReply reply = pingSender.Send(ipAddress);

            return reply.Status == IPStatus.Success;
        }
    }


}

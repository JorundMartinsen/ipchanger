using ipchanger_forms.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System;

namespace ipchanger_forms.Tools {
    public class NetworkManager {
        public IEnumerable<string> GetInterfaces() {
            foreach (var nic in NetworkInterface.GetAllNetworkInterfaces()) {
                yield return nic.Name;
            }
        }

        private string GetV4Format(int[] nums) {
            return nums.Select(i => i.ToString()).Aggregate((a, b) => a + "." + b);
        }

        public void SetIP(IIpConfigurationV4 conf, string nic) {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            if (conf.AutoIp) {
                startInfo.Arguments = string.Format("/C netsh interface ip set address {0} dhcp", nic);
            }
            else {
                var ip = GetV4Format(conf.Address);
                var mask = GetV4Format(conf.Mask);
                var gate = GetV4Format(conf.GateWay);
                startInfo.Arguments = string.Format("/C netsh interface ip set address {0} static {1} {2} {3}", nic, ip, mask, gate);
            }
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start();
        }
        
        public void SetIP(IIpConfigurationV6 conf, string nic) {
            throw new NotImplementedException();
        }
    }
}
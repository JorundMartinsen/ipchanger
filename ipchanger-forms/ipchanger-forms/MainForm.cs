using ipchanger_forms.Configuration;
using ipchanger_forms.Tools;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ipchanger_forms {
    public partial class MainMenu : Form {
        private List<IpConfigurationV4> _ipConfigurationV4s;
        private System.Diagnostics.Process _process;
        private System.Diagnostics.ProcessStartInfo _startInfo;
        public MainMenu() {
            InitializeComponent();
            _startInfo = new System.Diagnostics.ProcessStartInfo() {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                FileName = "cmd.exe"
            };
            _process = new System.Diagnostics.Process();
            _ipConfigurationV4s = new List<IpConfigurationV4>() {
                new IpConfigurationV4() {
                    Address=new int[] {192, 168, 0, 2 },
                    AutoDns = false,
                    AutoIp = false,
                    Comment = "Standard setting, using 192.168.0.2/192.168.0.1",
                    DNS1 = new int[] {8,8,8,8},
                    DNS2 = new int[] {6,6,6,6},
                    GateWay = new int[] {192, 168, 0, 1},
                    Mask = new int[] {255,255,255,0},
                    Name = "Standard, 192"
            },
                new IpConfigurationV4() {
                    Address=new int[] {10,0,0,2 },
                    AutoDns = false,
                    AutoIp = false,
                    Comment = "Standard setting, using 10.0.0.2/10.0.0.1",
                    DNS1 = new int[] {8,8,8,8},
                    DNS2 = new int[] {6,6,6,6},
                    GateWay = new int[] {10, 0, 0, 1},
                    Mask = new int[] {255,255,255,0},
                    Name = "Standard, 10"
                }
            };

        }

        private void SetIp(IIpConfigurationV4 ipConfiguration) {

        }
        private void SetIp(IIpConfigurationV6 ipConfiguration) {

        }

        private void menuItem7_Click(object sender, System.EventArgs e) {
            var manager = new NetworkManagement();
            manager.SetIP(new IpConfigurationV4() {
                Address = new int[] { 192, 168, 0, 14 },
                GateWay = new int[] { 192, 168, 0, 1 },
                Mask = new int[] { 255, 255, 255, 0 },
            }, "Ethernet");
        }
    }
}

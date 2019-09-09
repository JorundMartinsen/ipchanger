using ipchanger_forms.Configuration;
using ipchanger_forms.Tools;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ipchanger_forms {
    public partial class MainMenu : Form {
        private IEnumerable<IpConfigurationV4> configs;
        public MainMenu() {
            InitializeComponent();
            new IpConfigurationV4[] {
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
            });

        }

        private void cmbInterfaces_SelectedIndexChanged(object sender, System.EventArgs e) {

        }
    }
}

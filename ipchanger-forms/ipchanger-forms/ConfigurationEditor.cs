using ipchanger_forms.Configuration;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipchanger_forms {
    public partial class ConfigurationEditor : Form {
        public ObservableCollection<IpConfigurationV4> Configurations;
        public ConfigurationEditor(ConfigurationManager<IpConfigurationV4> configurationManager) {
            Configurations = new ObservableCollection<IpConfigurationV4>();
            foreach (var conf in configurationManager.LoadConfiguration) {
                Configurations.Add(conf);
            }
            Configurations.CollectionChanged += (object sender, NotifyCollectionChangedEventArgs e) => {
                configurationManager.SaveConfiguration = Configurations.ToArray();
            };
            InitializeComponent();
        }
    }
}

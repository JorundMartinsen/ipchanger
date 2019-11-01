using ipchanger_forms.Configuration;
using ipchanger_forms.Tools;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace ipchanger_forms {
    public partial class MainMenu : Form {
        public ObservableCollection<IpConfigurationV4> Configs { get; set; }
        public BindingSource BindingSource { get; set; }
        public IpConfigurationV4 CurrentConfig { get; set; }
        public NetworkManager NetworkManager { get; set; }
        public ConfigurationManager<IpConfigurationV4> ConfigurationManager { get; set; }
        public MainMenu() {
            InitializeComponent();
            NetworkManager = new NetworkManager();
            ConfigurationManager = new ConfigurationManager<IpConfigurationV4>(new Uri(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/ipChanger.config"));
            Configs = new ObservableCollection<IpConfigurationV4>();
            Configs.CollectionChanged += (object sender, NotifyCollectionChangedEventArgs e) => {
                SetRadioButtons();
            };
            foreach (var conf in ConfigurationManager.LoadConfiguration) {
                Configs.Add(conf);
            }
        }
        /// <summary>
        /// Clears and fills the flow panel with a radiobutton for each setting
        /// </summary>
        private void SetRadioButtons() {
            radioFlowPanel.Controls.Clear();
            foreach (var conf in Configs) {
                radioFlowPanel.Controls.Add(new CustomRadioButton<IpConfigurationV4>() {
                    Text = conf.AutoIp ? $"{conf.Name}, Auto, {conf.Comment}" : $"{conf.Name}, {conf.Address}, {conf.Comment}",
                    Configuration = conf
                });
            }
            foreach (CustomRadioButton<IpConfigurationV4> radioButton in radioFlowPanel.Controls) {
                radioButton.CheckedChanged += (object sender, EventArgs e) => {
                    if (sender is CustomRadioButton<IpConfigurationV4> radioButtonSender && radioButtonSender.Checked) {
                        CurrentConfig = radioButtonSender.Configuration;
                    }
                };
            }
        }
    }

    public class CustomRadioButton<T> : RadioButton {
        public CustomRadioButton() : base() { }
        public T Configuration { get; set; }
    }
}

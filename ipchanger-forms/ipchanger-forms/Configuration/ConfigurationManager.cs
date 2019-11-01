using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ipchanger_forms.Configuration {

    public class ConfigurationManagerBase {

        public Uri Uri { get; set; }
        public ConfigurationManagerBase(Uri uri) {
            Uri = uri;
        }
    }
    public class ConfigurationManagerIPv4 : ConfigurationManagerBase {
        public ConfigurationManagerIPv4(Uri uri) : base(uri) { }
        public IpConfigurationV4[] LoadConfiguration() {
            if (File.Exists(Uri.AbsolutePath))
                return JsonConvert.DeserializeObject<IpConfigurationV4[]>(File.ReadAllText(Uri.AbsolutePath));
            else return new IpConfigurationV4[] { new IpConfigurationV4() };
        }
        public async Task SaveConfiguration(IpConfigurationV4 conf) {
            await Task.Run(() => File.WriteAllText(Uri.AbsolutePath, JsonConvert.SerializeObject(conf)));
        }
    }

    public class ConfigurationManager<T> : ConfigurationManagerBase where T : IIpConfigurationBase {
        public ConfigurationManager(Uri uri) : base(uri) { }
        public IIpConfigurationBase[] LoadConfiguration() {
            if (File.Exists(Uri.AbsolutePath))
                return JsonConvert.DeserializeObject<IIpConfigurationBase[]>(File.ReadAllText(Uri.AbsolutePath));
            else {
                if(typeof(T) == typeof(IpConfigurationV4))
                return new IIpConfigurationBase[] { new IpConfigurationV4() };
                if(typeof(T) == typeof(IpConfigurationV6))
                return new IIpConfigurationBase[] { new IpConfigurationV6() };
            }
            return new IIpConfigurationBase[] { };
        }
        public async Task SaveConfiguration(IIpConfigurationBase conf) {
            await Task.Run(() => File.WriteAllText(Uri.AbsolutePath, JsonConvert.SerializeObject(conf)));
        }
    }
}

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
        public IpConfigurationV4[] LoadConfigurationIpV4() {
            if (File.Exists(Uri.AbsolutePath))
                return JsonConvert.DeserializeObject<IpConfigurationV4[]>(File.ReadAllText(Uri.AbsolutePath));
            return new IpConfigurationV4[] { new IpConfigurationV4() };
        }
        public IpConfigurationV6[] LoadConfigurationIpV6() {
            if (File.Exists(Uri.AbsolutePath))
                return JsonConvert.DeserializeObject<IpConfigurationV6[]>(File.ReadAllText(Uri.AbsolutePath));
            return new IpConfigurationV6[] { new IpConfigurationV6() };
        }
        public async Task SaveConfiguration(IIpConfigurationBase conf) {
            await Task.Run(() => File.WriteAllText(Uri.AbsolutePath, JsonConvert.SerializeObject(conf)));
        }
    }
}

using System;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ipchanger_forms.Configuration {

    public class ConfigurationManagerBase {

        public Uri Uri { get; set; }
        private readonly JsonSerializer _serializer;
        private readonly JsonReader _reader;
        public ConfigurationManagerBase(Uri uri) {
            _serializer = new JsonSerializer();
            Uri = uri;
        }
    }
    public class ConfigurationManagerIPv4 : ConfigurationManagerBase {
        public ConfigurationManagerIPv4(Uri uri) : base(uri) { }
        public IpConfigurationV4[] LoadConfiguration {
            get {
                if (File.Exists(Uri.AbsolutePath))
                    return JsonConvert.DeserializeObject<IpConfigurationV4[]>(File.ReadAllText(Uri.AbsolutePath));
                else return new IpConfigurationV4[] { new IpConfigurationV4() };
            }
        }
        public async Task SaveConfiguration(IpConfigurationV4 conf) {
            await Task.Run(() => File.WriteAllText(Uri.AbsolutePath, JsonConvert.SerializeObject(conf)));
        }
    }
}

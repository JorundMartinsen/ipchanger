using Newtonsoft.Json;
using System;
using System.IO;

namespace ipchanger_forms.Configuration {
    public class ConfigurationManager<T> {
        public Uri Uri { get; set; }
        private readonly JsonSerializer _serializer;
        private readonly JsonReader _reader;
        public ConfigurationManager(Uri uri) {
            _serializer = new JsonSerializer();
            Uri = uri;
        }
        public T[] LoadConfiguration {
            get {
                return JsonConvert.DeserializeObject<T[]>(File.ReadAllText(Uri.AbsolutePath));
            }
        }
        public T[] SaveConfiguration {
            set {
                File.WriteAllText(Uri.AbsolutePath, JsonConvert.SerializeObject(value));
            }
        }
    }
}

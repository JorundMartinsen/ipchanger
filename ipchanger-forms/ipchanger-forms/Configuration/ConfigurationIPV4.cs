using System;
using System.Linq;

namespace ipchanger_forms.Configuration {
    public class IpConfigurationV4 : IIpConfigurationV4 {
        private int[] _mask;
        public int[] Mask {
            get {
                return GetterV4(_mask, new int[] { 255, 255, 255, 0 });
            }
            set {
                if (value.Length != 4) throw new ArgumentException("Mask needs four values");
                else _mask = value;
            }
        }
        public string Name { get; set; }
        public string Comment { get; set; }
        public bool AutoIp { get; set; }
        public bool AutoDns { get; set; }
        private int[] _address;
        public int[] Address {
            get {
                return GetterV4(_address);
            }
            set {
                if (value.Length != 4) throw new ArgumentException("Address needs four values");
                else _address = value;
            }
        }
        private int[] _gateway;
        public int[] GateWay {
            get {
                return GetterV4(_gateway);
            }
            set {
                if (value.Length != 4) throw new ArgumentException("GateWay needs four values");
                else _gateway = value;
            }
        }
        private int[] _dns1;
        public int[] DNS1 {
            get {
                return GetterV4(_dns1);
            }
            set {
                if (value.Length != 4) throw new ArgumentException("DNS needs four values");
                else _dns1 = value;
            }
        }
        private int[] _dns2;
        public int[] DNS2 {
            get {
                return GetterV4(_dns2);
            }
            set {
                if (value.Length != 4) throw new ArgumentException("DNS needs four values");
                else _dns2 = value;
            }
        }

        private int[] GetterV4(int[] value) {
            return GetterV4(value, new int[] { 0, 0, 0, 0 });
        }

        private int[] GetterV4(int[] value, int[] d) {
            if (value.Length == 4) {
                return value;
            }
            else if (value.Length > 4) {
                return value.Take(4).ToArray();
            }
            else {
                int[] ret = d;
                for (int i = 0; i < value.Length; i++) {
                    ret[i] = value[i];
                }
                return ret;
            }
        }
    }
}

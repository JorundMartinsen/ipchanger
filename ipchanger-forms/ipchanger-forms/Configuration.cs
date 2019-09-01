using System;
using System.Linq;

namespace ipchanger_forms {
    public interface IIpConfigurationBase<T> {
        string Name { get; set; }
        string Comment { get; set; }
        bool AutoIp { get; set; }
        bool AutoDns { get; set; }
        T Address { get; set; }
        T GateWay { get; set; }
        T DNS1 { get; set; }
        T DNS2 { get; set; }
    }

    public interface IIpConfigurationV6 : IIpConfigurationBase<string> {
        int SubnetLength { get; set; }
    }

    public interface IIpConfigurationV4 : IIpConfigurationBase<int[]> {
        int[] Mask { get; set; }
    }

    public enum IpVersion {
        Ipv6,
        Ipv4
    }

    public class IpConfigurationV4 : IIpConfigurationV4 {
        private int[] _mask;
        public int[] Mask {
            get {
                return getterV4(_mask, new int[] { 255, 255, 255, 0 });
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
                return getterV4(_address);
            }
            set {
                if (value.Length != 4) throw new ArgumentException("Address needs four values");
                else _address = value;
            }
        }
        private int[] _gateway;
        public int[] GateWay {
            get {
                return getterV4(_gateway);
            }
            set {
                if (value.Length != 4) throw new ArgumentException("GateWay needs four values");
                else _gateway = value;
            }
        }
        private int[] _dns1;
        public int[] DNS1 {
            get {
                return getterV4(_dns1);
            }
            set {
                if (value.Length != 4) throw new ArgumentException("DNS needs four values");
                else _dns1 = value;
            }
        }
        private int[] _dns2;
        public int[] DNS2 {
            get {
                return getterV4(_dns2);
            }
            set {
                if (value.Length != 4) throw new ArgumentException("DNS needs four values");
                else _dns2 = value;
            }
        }

        int[] getterV4(int[] value) {
            return getterV4(value, new int[] { 0, 0, 0, 0 });
        }

        int[] getterV4(int[] value, int[] d) {
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

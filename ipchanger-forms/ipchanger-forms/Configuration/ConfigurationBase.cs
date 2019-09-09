namespace ipchanger_forms.Configuration {
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
}

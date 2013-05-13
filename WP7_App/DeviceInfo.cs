using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public partial class DeviceInfo
    {
        private static DeviceInfo _default;
        public static DeviceInfo Default
        {
            get
            {
                if (_default == null)
                    _default = new DeviceInfo();
                return _default;
            }
        }

        private DeviceInfo()
        {
        }
    }
}

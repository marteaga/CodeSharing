using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Common
{
    public partial class DeviceInfo
    {
        private string m_DeviceUniqueId;
        public string DeviceId
        {
            get
            {
                if (m_DeviceUniqueId == null)
                {
                    object val;
                    if (Microsoft.Phone.Info.DeviceExtendedProperties.TryGetValue("DeviceUniqueId", out val))
                        m_DeviceUniqueId = Convert.ToBase64String((val as byte[]));
                }
                return m_DeviceUniqueId;
            }
        }
    }
}

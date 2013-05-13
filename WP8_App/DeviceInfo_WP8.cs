using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    m_DeviceUniqueId = Windows.Phone.System.Analytics.HostInformation.PublisherHostId;
                }
                return m_DeviceUniqueId;
            }
        }
    }
}
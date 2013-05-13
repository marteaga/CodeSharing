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
                    var token = Windows.System.Profile.HardwareIdentification.GetPackageSpecificToken(null);
                    var hardwareId = token.Id;
                    var dataReader = Windows.Storage.Streams.DataReader.FromBuffer(hardwareId);

                    byte[] bytes = new byte[hardwareId.Length];
                    dataReader.ReadBytes(bytes);

                    m_DeviceUniqueId = BitConverter.ToString(bytes).Replace("-","");
                }
                return m_DeviceUniqueId;
            }
        }
    }
}
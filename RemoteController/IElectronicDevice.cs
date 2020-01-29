using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoteController
{
    interface IElectronicDevice
    {
        void On();
        void Off();
        void VolumeUp();
        void VolumeDown();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battery
{
    class BatteryPassport
    {
        private static int passportCounter = 0; // shared counter
        private string serialNumber;

        // Read-only access to serial number
        public string SerialNumber
        {
            get { return serialNumber; }
        }

        public BatteryPassport()
        {
            passportCounter++;
            serialNumber = "BP-" + passportCounter.ToString("D6");
        }
    }
}

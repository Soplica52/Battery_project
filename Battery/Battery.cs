using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battery
{
    enum BatteryType
    {
        lithium_ion,
        nickel_cadium,
        solid_oxide,
        lead_acid
    }
    class Battery
    {
        BatteryType type;
        double capacity; //[Ah]
        double nominalVoltage; //[V]
        string isolationColour;
        double SOC; // [0-100%]
        int maximumTemperature;
        bool isDamaged;

        //method for displaying the parameters values
        public void DisplayParam()
        {
            MessageBox.Show("Battery type: " + type.ToString() + "\r\n" +
                "Capacity: " + capacity.ToString() + "\r\n" +
                "Nominal Voltage: " + nominalVoltage.ToString() + "\r\n" +
                "Isolation colour: " + isolationColour + "\r\n" +
                "State of Charge: " + SOC.ToString() + "\r\n" +
                "Maximum temperature: " + maximumTemperature.ToString() + "\r\n" +
                "Is Damaged? : " + isDamaged.ToString() + "\r\n");
        }
    }
}

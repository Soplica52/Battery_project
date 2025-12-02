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

        public static int batteryObjectNumber { get; set; }

        public Battery()
        {
            type = BatteryType.lithium_ion;
            capacity = 10000;
            nominalVoltage = 5;
            isolationColour = "brown";
            SOC = 80;
            maximumTemperature = 60;
            isDamaged = false;

            //every time the object is created 
            batteryObjectNumber++;
        }

        public Battery(
            double capacity,
            double nominalVoltage,
            double SOC,
            int maximumTemperature,
            bool isDamaged)
        {
            this.capacity = capacity;
            this.nominalVoltage = nominalVoltage;
            this.SOC = SOC;
            this.maximumTemperature = maximumTemperature;
            this.isDamaged = isDamaged;

            batteryObjectNumber++;
        }
        
        //Destructor
        ~Battery()
        {
            MessageBox.Show("Battery is destroyed (destructor is working just now)");
        }

        public double socChange
        {
            set
            {
                // Specify and control limits of SOC parameter
                if (value > 100)
                {
                    value = 100;
                }
                else if (value < 0)
                {
                    value = 0;
                }
                
                    SOC = value;
                
            }
            get
            {
                
                //areato specify and controll return process of SOC value
                return SOC;
            }
        }
        
        

        //method for displaying the parameters values
        public void DisplayParam()
        {
            MessageBox.Show("Battery type: " + type.ToString() + "\r\n" +
                "Capacity: " + capacity.ToString() + " mAh" + "\r\n" +
                "Nominal Voltage: " + nominalVoltage.ToString() + " V" + "\r\n" +
                "Isolation colour: " + isolationColour + "\r\n" +
                "State of Charge: " + SOC.ToString() + " %" + "\r\n" +
                "Maximum temperature: " + maximumTemperature.ToString() + " degrees" + "\r\n" +
                "Is Damaged? : " + isDamaged.ToString() + "\r\n");
        }
    }
}

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
    class Battery:EnergyStorage //
    {
        BatteryType type;
        double capacity; //[Ah]
        double nominalVoltage; //[V]
        string isolationColour;
        double SOC; // [0-100%]
        int maximumTemperature;
        bool isDamaged;


        private BatteryPassport passport;

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

            passport = new BatteryPassport(); // assign passport

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
            MessageBox.Show("Battery Passport: " + passport.SerialNumber + "\r\n" +
                "Battery type: " + type.ToString() + "\r\n" +
                "Capacity: " + capacity.ToString() + " mAh" + "\r\n" +
                "Nominal Voltage: " + nominalVoltage.ToString() + " V" + "\r\n" +
                "Isolation colour: " + isolationColour + "\r\n" +
                "State of Charge: " + SOC.ToString() + " %" + "\r\n" +
                "Maximum temperature: " + maximumTemperature.ToString() + " degrees" + "\r\n" +
                "Is Damaged? : " + isDamaged.ToString() + "\r\n");
        }
        public static double operator +(Battery b1, Battery b2)
        {
            MessageBox.Show("Two batteranodfnvaofdkjvn");
            return b1.nominalVoltage + b2.nominalVoltage;
        }
        public static double operator |(Battery b1, Battery b2)
        {
            MessageBox.Show("Capacity");
            return (b1.capacity + b2.capacity) / 2;
        }
        public static Battery operator *(Battery b1, Battery b2)
        {
            Battery battery = new Battery();
            battery.nominalVoltage = b1.nominalVoltage + b2.nominalVoltage;
            battery.socChange = (b1.SOC + b2.SOC) / 2;

            battery.DisplayParam();

            return battery;
        }

    }
}

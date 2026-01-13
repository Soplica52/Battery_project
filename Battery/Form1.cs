using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battery
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // object declaration and creation
            Battery battery = new Battery();

            //calling method from class (necessary to use object battery)
            battery.DisplayParam();
            
            // change the vaues of object fields
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Battery bat = new Battery(100.343, 13.234, 55, 100, true);
            bat.DisplayParam();

            bat.socChange = 2020;
            bat.DisplayParam();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GC.Collect(1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Battery.batteryObjectNumber.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Battery battery1 = new Battery(23.2, 12, 50, 8, false);
            Battery battery2 = new Battery(21.2, 25, 2, 25, false);
            Battery bat3 = new Battery();

            double seriesTotalVoltage = battery1 + battery2;

            double totalCapacity = battery1 | battery2;

            MessageBox.Show(seriesTotalVoltage.ToString());

            MessageBox.Show(totalCapacity.ToString());
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        //declaration of the object
        EnergyStorage energyStorage;

        private void button6_Click(object sender, EventArgs e)
        {
            //create the object and disable the button after clicking
            //energyStorage = new EnergyStorage();
            energyStorage = new Battery();
            button5.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            energyStorage.Charge(5);

            //update the chart
            energyStorage.DrawSOCPlot(chart1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            energyStorage.Discharge(5);

            //update the chart
            energyStorage.DrawSOCPlot(chart1);
        }
    }
}

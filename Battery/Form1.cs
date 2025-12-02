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
    }
}

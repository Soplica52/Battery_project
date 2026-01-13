using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battery
{
    class EnergyStorage
    {
        string description;
        double actualSOC;
        double[] previousSOCvalues;

        public EnergyStorage()
        {
            previousSOCvalues = new double[0];
        }

        public void DisplayActualSOC()
        {
            System.Windows.Forms.MessageBox.Show("Actual SOC of energy storage: " + actualSOC.ToString() + "%");
        }

        public void Charge(double dQ)
        {
            actualSOC += dQ;

            // increase size of array by 1 element

            Array.Resize(ref previousSOCvalues,previousSOCvalues.Length+1);
            previousSOCvalues[previousSOCvalues.Length - 1] = actualSOC;
        }

        public void Discharge(double dQ)
        {
            actualSOC -= dQ;

            // increase size of array by 1 element

            Array.Resize(ref previousSOCvalues, previousSOCvalues.Length + 1);
            previousSOCvalues[previousSOCvalues.Length - 1] = actualSOC;
        }

        public void DrawSOCPlot(System.Windows.Forms.DataVisualization.Charting.Chart chart)
        {
            chart.Series[0].Points.Clear();

            for (int i = 0; i < previousSOCvalues.Length; i++)
            {
                chart.Series[0].Points.AddY(previousSOCvalues[i]);
            }

        }
    }
}

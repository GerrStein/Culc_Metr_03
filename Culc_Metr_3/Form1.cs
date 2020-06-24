using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Culc_Metr_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static double CostCM2(double a, double b)
        {
            return a / (b * 100);
        }

        public static double PieceSquare(double a, double b)
        {
            return a * b;
        }

        public static double Multiplication(double costCM2, double pieceSquare)
        {
            return costCM2 * pieceSquare;

        }

        private void Math1(object input)
        {
            tbCost1.Text = Convert.ToString(CostCM2(Convert.ToDouble(tbCostMetr.Text), Convert.ToDouble(tbFabricWidth.Text)));

        }

        private void Math2(object input)
        {
            tbCost2.Text = Convert.ToString(PieceSquare(Convert.ToDouble(tbSectionLength.Text), Convert.ToDouble(tbSectionWidth.Text)));
        }

        private void Math3(object input)
        {

            tbEndCalc.Text = Convert.ToString(Multiplication(Convert.ToDouble(tbCost1.Text), Convert.ToDouble(tbCost2.Text)));

        }

        private void btMath_Click_1(object sender, EventArgs e)
        {
            #region
            tbCost1.Text = Convert.ToString(CostCM2(Convert.ToDouble(tbCostMetr.Text), Convert.ToDouble(tbFabricWidth.Text)));
            tbCost2.Text = Convert.ToString(PieceSquare(Convert.ToDouble(tbSectionLength.Text), Convert.ToDouble(tbSectionWidth.Text)));
            tbEndCalc.Text = Convert.ToString(Multiplication(Convert.ToDouble(tbCost1.Text), Convert.ToDouble(tbCost2.Text)));
            #endregion
            Thread thread1 = new Thread(Math1);
            thread1.Start();
            Thread thread2 = new Thread(Math2);
            thread2.Start();
            Thread thread3 = new Thread(Math3);
            thread3.Start();

        }
    }
}

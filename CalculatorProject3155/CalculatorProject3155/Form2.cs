using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorProject3155
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void UnitConversionButton_Click(object sender, EventArgs e)
        {
            Form4 myForm = new Form4();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void CurrencyConversionButton_Click(object sender, EventArgs e)
        {
            InputAmountTextbox myForm = new InputAmountTextbox();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void GraphingButton_Click(object sender, EventArgs e)
        {
            Form5 myForm = new Form5();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void BasicOperationsButton_Click(object sender, EventArgs e)
        {
            Form1 myForm = new Form1();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}

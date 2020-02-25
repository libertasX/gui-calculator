using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 

        private void CalculateClick(object sender, EventArgs e)
        {
            if (radioButtonAdditon.Checked)
            {
                double x = Convert.ToDouble(textBox_1.Text);
                double y = Convert.ToDouble(textBox_2.Text);

                // calculate
                double ergebnis = x + y;
                labelResult.Text = Convert.ToString(ergebnis);
            }

            if (radioButtonSubtraction.Checked)
            {
                double x = Convert.ToDouble(textBox_1.Text);
                double y = Convert.ToDouble(textBox_2.Text);

                // calculate
                double ergebnis = x - y;
                labelResult.Text = Convert.ToString(ergebnis);
            }

            if (radioButtonMultiplication.Checked)
            {
                double x = Convert.ToDouble(textBox_1.Text);
                double y = Convert.ToDouble(textBox_2.Text);

                // calculate
                double ergebnis = x * y;
                labelResult.Text = Convert.ToString(ergebnis);
            }

            if (radioButtonDivision.Checked)
            {
                double x = Convert.ToDouble(textBox_1.Text);
                double y = Convert.ToDouble(textBox_2.Text);

                // calculate
                double ergebnis = x / y;
                labelResult.Text = Convert.ToString(ergebnis);
            }

        }

        private void CleanClick(object sender, EventArgs e)
        {
            textBox_1.Text = "";
            textBox_2.Text = "";
            labelResult.Text = "";
            radioButtonAdditon.Checked = false;
            radioButtonSubtraction.Checked = false;
            radioButtonMultiplication.Checked = false;
            radioButtonDivision.Checked = false;
          

        }

        private void ExitClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Wollen Sie die Anwendung wirklich beenden ?", "Anwendung beenden ?",
                MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

    }
}

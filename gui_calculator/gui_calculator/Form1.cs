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

        private void Cmd_Berechnen_Click(object sender, EventArgs e)
        {
            if (RB_Addition.Checked == true)
            {
                double zahl_1 = Convert.ToDouble(Text_Box_1.Text);
                double zahl_2 = Convert.ToDouble(Text_Box_2.Text);

                // berechnen
                double ergebnis = zahl_1 + zahl_2;
                Text_Box_Ergebnis.Text = Convert.ToString(ergebnis);
            }

            if (RB_Subtraktion.Checked == true)
            {
                double zahl_1 = Convert.ToDouble(Text_Box_1.Text);
                double zahl_2 = Convert.ToDouble(Text_Box_2.Text);

                // berechnen
                double ergebnis = zahl_1 - zahl_2;
                Text_Box_Ergebnis.Text = Convert.ToString(ergebnis);
            }

            if (RB_Multiplikation.Checked == true)
            {
                double zahl_1 = Convert.ToDouble(Text_Box_1.Text);
                double zahl_2 = Convert.ToDouble(Text_Box_2.Text);

                // berechnen
                double ergebnis = zahl_1 * zahl_2;
                Text_Box_Ergebnis.Text = Convert.ToString(ergebnis);
            }

            if (RB_Division.Checked == true)
            {
                double zahl_1 = Convert.ToDouble(Text_Box_1.Text);
                double zahl_2 = Convert.ToDouble(Text_Box_2.Text);

                // berechnen
                double ergebnis = zahl_1 / zahl_2;
                Text_Box_Ergebnis.Text = Convert.ToString(ergebnis);
            }

        }

        private void Cmd_Clean_Click(object sender, EventArgs e)
        {
            Text_Box_1.Text = "";
            Text_Box_2.Text = "";
            Text_Box_Ergebnis.Text = "";

        }

        private void Cmd_Beenden_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Wollen Sie die Anwendung wirklich beenden ?", "Anwendung beenden ?",
                MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

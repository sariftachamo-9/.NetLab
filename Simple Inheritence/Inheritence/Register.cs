using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace inheritence
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var province = comboBox1.SelectedItem.ToString();
            List<string> bagmatiDistricts = new List<string> { "Kathmandu", "Bhaktapur", "Lalitpur" };
            List<string> gandakiDistricts = new List<string> { "Kaski", "Lamjung", "Manang" };

            comboBox2.Items.Clear();
            switch (province)
            {
                case "Bagmati":
                    comboBox2.Items.AddRange(bagmatiDistricts.ToArray());
                    MessageBox.Show("You are added to Bagmati Provience");
                    break;
                case "Gandaki":
                    comboBox2.Items.AddRange(gandakiDistricts.ToArray());
                    MessageBox.Show("You are added to Gandaki Provience");
                    break;
                default:
                    comboBox2.Items.Clear();
                    MessageBox.Show("Check Your Data And Try Again");

                    break;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Clear the text fields
            textBox1.Clear();

            // Reset the numeric up-down control
            numericUpDown1.Value = numericUpDown1.Minimum;

            // Reset combo boxes
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

            // Uncheck all items in the checked list box
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }

            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}

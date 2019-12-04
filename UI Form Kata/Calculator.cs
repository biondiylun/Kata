using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Form_Kata
{
    public partial class Calculator : Form
    {
        private int totalNumber = 0;
        private int setNumber = 0;
        public Calculator()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                setNumber = 1;
                checkBox1.BackColor = System.Drawing.Color.Red;
            } else if (checkBox1.Checked == false) 
            {
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
                checkBox7.Enabled = true;
                checkBox8.Enabled = true;
                checkBox9.Enabled = true;
                setNumber = 0;
                checkBox1.BackColor = System.Drawing.Color.Blue;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                setNumber = 2;
            }
            else if (checkBox2.Checked == false)
            {
                checkBox1.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
                checkBox7.Enabled = true;
                checkBox8.Enabled = true;
                checkBox9.Enabled = true;
                setNumber = 0;
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                setNumber = 3;
            }
            else if (checkBox3.Checked == false)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
                checkBox7.Enabled = true;
                checkBox8.Enabled = true;
                checkBox9.Enabled = true;
                setNumber = 0;
            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                setNumber = 4;
            }
            else if (checkBox4.Checked == false)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
                checkBox7.Enabled = true;
                checkBox8.Enabled = true;
                checkBox9.Enabled = true;
                setNumber = 0;
            }
        }
        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                setNumber = 5;
            }
            else if (checkBox5.Checked == false)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox6.Enabled = true;
                checkBox7.Enabled = true;
                checkBox8.Enabled = true;
                checkBox9.Enabled = true;
                setNumber = 0;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                setNumber = 6;
            }
            else if (checkBox6.Checked == false)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox7.Enabled = true;
                checkBox8.Enabled = true;
                checkBox9.Enabled = true;
                setNumber = 0;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox8.Enabled = false;
                checkBox9.Enabled = false;
                setNumber = 7;
            }
            else if (checkBox7.Checked == false)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
                checkBox8.Enabled = true;
                checkBox9.Enabled = true;
                setNumber = 0;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox9.Enabled = false;
                setNumber = 8;
            }
            else if (checkBox8.Checked == false)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
                checkBox7.Enabled = true;
                checkBox9.Enabled = true;
                setNumber = 0;
            }
        }
        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked == true)
            {
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox6.Enabled = false;
                checkBox7.Enabled = false;
                checkBox8.Enabled = false;
                setNumber = 9;
            }
            else if (checkBox9.Checked == false)
            {
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                checkBox6.Enabled = true;
                checkBox7.Enabled = true;
                checkBox8.Enabled = true;
                setNumber = 0;
            }
        }
        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked == true)
            {
                checkBox11.Enabled = false;
                checkBox12.Enabled = false;
                checkBox13.Enabled = false;
                totalNumber = setNumber + totalNumber;
            }
            else if (checkBox10.Checked == false)
            {
                checkBox11.Enabled = true;
                checkBox12.Enabled = true;
                checkBox13.Enabled = true;
            }
        }
        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked == true)
            {
                checkBox10.Enabled = false;
                checkBox12.Enabled = false;
                checkBox13.Enabled = false;
                totalNumber = totalNumber - setNumber;
            }
            else if (checkBox11.Checked == false)
            {
                checkBox10.Enabled = true;
                checkBox12.Enabled = true;
                checkBox13.Enabled = true;
            }
        }
        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked == true)
            {
                checkBox10.Enabled = false;
                checkBox11.Enabled = false;
                checkBox13.Enabled = false;
                MessageBox.Show("This is not yet implemented", "Unimplemented", MessageBoxButtons.YesNo);
            }
            else if (checkBox12.Checked == false)
            {
                checkBox10.Enabled = true;
                checkBox11.Enabled = true;
                checkBox13.Enabled = true;
                MessageBox.Show("This is not yet implemented", "Unimplemented", MessageBoxButtons.YesNo);
            }
        }
        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked == true)
            {
                checkBox10.Enabled = false;
                checkBox11.Enabled = false;
                checkBox12.Enabled = false;
                MessageBox.Show("This is not yet implemented", "Unimplemented", MessageBoxButtons.YesNo);
            }
            else if (checkBox13.Checked == false)
            {
                checkBox10.Enabled = true;
                checkBox11.Enabled = true;
                checkBox12.Enabled = true;
                MessageBox.Show("This is not yet implemented", "Unimplemented", MessageBoxButtons.YesNo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(totalNumber.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            totalNumber = 0;
        }
    }
}

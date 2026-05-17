using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] arr = new string[3];
            arr[0] = "Bangladesh";
            arr[1] = "India";
            arr[2] = "Pakistan";
            comboBox1.DataSource = arr;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string id = idTextBox.Text;
            string date = dateTimePiker.Text;
            string add = addressRichBox.Text;
            string gendar;
            if(radioButton1.Checked)
            {
                gendar = radioButton1.Text;

            }
            else if(radioButton2.Checked)
            {
                gendar = radioButton2.Text;

            }
            else
            {
                gendar = radioButton3.Text;
            }

            string nation = comboBox1.SelectedItem.ToString();

         
          // MessageBox.Show(name + " " + id + " " + date+" "+ gendar+" "+nation+" "+add);

            string details = name + " \n" + id + "\n " + date + "\n " + gendar + "\n " + nation + " \n" + add;

            this.Hide();
            Form f2 = new Form2(details);
            f2.Show();

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { idTextBox.UseSystemPasswordChar = false; }

            else { idTextBox.UseSystemPasswordChar = true; }

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

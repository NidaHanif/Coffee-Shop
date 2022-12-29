using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_Shop
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (namecombo.SelectedItem.ToString() == "Lattie")
            {
                if (typecombo.SelectedItem.ToString() == "Frapp")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 90).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 70).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 50).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quantitycombo.Text, paytext.Text);
            }
            else if (namecombo.SelectedItem.ToString() == "Chappaccino")
            {
                if (typecombo.SelectedItem.ToString() == "Frapp")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 100).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 80).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 60).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quantitycombo.Text, paytext.Text);
            }
            if (namecombo.SelectedItem.ToString() == "Chocolate")
            {
                if (typecombo.SelectedItem.ToString() == "Frapp")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 200).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Ice")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 150).ToString();
                }
                if (typecombo.SelectedItem.ToString() == "Hot")
                {
                    paytext.Text = (float.Parse(quantitycombo.Text) * 120).ToString();
                }
                dataGridView1.Rows.Add(idtext.Text, namecombo.Text, typecombo.Text, quantitycombo.Text, paytext.Text);

            }
        }

        private void idtext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar))
            {

            }
            else
            {
                e.Handled = e.KeyChar != (Char)Keys.Back;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            idtext.Text = "";
            namecombo.Text = "";
            typecombo.Text = "";
            quantitycombo.Text = "";
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paytext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

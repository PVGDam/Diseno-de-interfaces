using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label5.ForeColor = Color.IndianRed;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label8.ForeColor = Color.IndianRed;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label7.ForeColor = Color.IndianRed;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label6.ForeColor = Color.IndianRed;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            string contenido = textBox1.Text;

            if (string.IsNullOrWhiteSpace(contenido))
            {
                errorProvider1.SetError(textBox1, "Este campo es obligatorio.");
                return;
            }
            else
            {
                if (Regex.IsMatch(contenido, @"^\d{8}\w$"))
                {
                    errorProvider1.SetError(textBox1, "");
                }
                else
                {
                    errorProvider1.SetError(textBox1, "El NIF es incorrecto");
                }
            }
        } // Voy con Luis, Jose con Andres, Antonio con Alberto

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            string contenido = textBox3.Text;

            if (string.IsNullOrWhiteSpace(contenido))
            {
                errorProvider1.SetError(textBox3, "Este campo es obligatorio.");
                return;
            }
            else
            {
                
                if (Regex.IsMatch(contenido, @"^\w+$")) {
                    errorProvider1.SetError(textBox3, "");
                }
                else {
                    errorProvider1.SetError(textBox3, "El nombre es incorrecto");
                }
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            string contenido = textBox2.Text;

            if (string.IsNullOrWhiteSpace(contenido))
            {
                errorProvider1.SetError(textBox2, "Este campo es obligatorio.");
                return;
            }
            else
            {
                if (Regex.IsMatch(contenido, @"^\w+$"))
                {
                    errorProvider1.SetError(textBox2, "");
                }
                else
                {
                    errorProvider1.SetError(textBox2, "El apellido es incorrecto");
                }
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {
            string contenido = textBox4.Text;

            if (string.IsNullOrWhiteSpace(contenido))
            {
                errorProvider1.SetError(textBox4, "Este campo es obligatorio.");
                return;
            }
            else
            {
                if (Regex.IsMatch(contenido, @"^\w+([.-]\w+)*@\w+([.-]\w+)*\.\w{2,}$"))
                {
                    errorProvider1.SetError(textBox4, "");
                }
                else
                {
                    errorProvider1.SetError(textBox4, "El email es incorrecto");
                }
            }
        }
    }
}

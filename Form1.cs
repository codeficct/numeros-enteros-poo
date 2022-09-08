using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroEntero_poo
{
    public partial class Form1 : Form
    {
        IntegerNumber objNumber1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objNumber1 = new IntegerNumber();
        }

        // Message Error
        public void errorHandler(string message, string title)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Length == 0) throw new ArgumentException("Por favor ingrese un dato.");
                objNumber1.setNumber(int.Parse(textBox1.Text));
            }
            catch (Exception error)
            {
                errorHandler(error.Message, "Datos incorrectos o faltantes.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = objNumber1.getNumber().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void isParToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox2.Text = objNumber1.isEven().ToString();
        }

        private void isMultipleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int multiple = int.Parse(textBox3.Text);
            textBox2.Text = objNumber1.isMultiple(multiple).ToString();
        }
    }
}

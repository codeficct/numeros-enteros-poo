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
        Vector objVector1, objVector2;
        IntegerNumber objIntNumber1;
        private Button currentButton;
        int currentExercise = 0;
        bool isDisable = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objVector1 = new Vector();
            objVector2 = new Vector();
            objIntNumber1 = new IntegerNumber();
        }

        // Message Error
        public void errorHandler(string message)
        {
            MessageBox.Show(message, "Datos incorrectos o faltantes.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void ActivateButton(Object senderBtn, int currentValue)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentButton = (Button)senderBtn;
                currentButton.BackColor = Color.SkyBlue;
                buttonRun.Enabled = true;
                labelRun.Text = "Ejercicio " + currentValue.ToString();
            }
        }

        public void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.AliceBlue;
                labelParam1.Visible = false;
                textBoxParam1.Visible = false;
                textBoxMax.Enabled = true;
                textBoxMin.Enabled = true;
                isDisable = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isDisable) textBoxResults.Text = objVector1.GetNumbers().ToString();
            else textBoxResults.Text = objIntNumber1.getNumber().ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBoxMax.Clear();
            textBoxMin.Clear();
            textBoxSet.Clear();
            textBoxParam1.Clear();
            textBoxResults.Clear();
            textBoxRes.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, 1);
            labelTitle.Text = "Verificar si es par";
            currentExercise = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, 2);
            labelTitle.Text = "Verificar si un número entero es\nmúltiplo de otro número entero";
            labelParam1.Visible = true;
            textBoxParam1.Visible = true;
            currentExercise = 2;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, 3);
            labelTitle.Text = "Verificar si un número entero es\nsub múltiplo de otro número entero";
            currentExercise = 3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, 4);
            labelTitle.Text = "Verificar si es primo";
            currentExercise = 4;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, 5);
            labelTitle.Text = "Verificar si es capicúa o palindromo";
            currentExercise = 5;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, 6);
            labelTitle.Text = "Verificar si es de la serie de Fibonacci";
            currentExercise = 6;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, 7);
            labelTitle.Text = "Obtener el factorial de un número entero";
            currentExercise = 7;
            textBoxMax.Enabled = false;
            textBoxMin.Enabled = false;
            isDisable = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, 8);
            labelTitle.Text = "Verificar si los dígitos de un número entero\nestán ordenados";
            currentExercise = 8;
            textBoxMax.Enabled = false;
            textBoxMin.Enabled = false;
            isDisable = true;
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info = "Nombre: Luis Gabriel Janco Alvarez\nMateria: Programación 1\nGrupo: INF120 SB\nRegistro: 220104875";
            MessageBox.Show(info, "Información del Estudiante", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSet.Text == "") throw new ArgumentException("Introduce un número entero.");
                if (!isDisable && textBoxMax.Text.Length == 0) throw new ArgumentException("Introduce el rango (maximo).");
                if (!isDisable && textBoxMin.Text.Length == 0) throw new ArgumentException("Introduce el rango (minimo).");
                int value = int.Parse(textBoxSet.Text);
                if (!isDisable)
                {
                    int max = int.Parse(textBoxMax.Text), min = int.Parse(textBoxMin.Text);
                    objVector1.SetNumber(value, max, min);
                }
                objIntNumber1.setNumber(int.Parse(textBoxSet.Text));
            }
            catch (Exception error)
            {
                errorHandler(error.Message);
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSet.Text == "") throw new ArgumentException("Primero debes Cargar!");
                switch (currentExercise)
                {
                    case 1:
                        objVector1.SelectPairs(ref objVector2);
                        textBoxResults.Text = objVector2.GetNumbers();
                        textBoxRes.Text = objIntNumber1.isEven().ToString();
                        break;
                    case 2:
                        if (textBoxParam1.Text.Length == 0) throw new ArgumentException("Debes especificar el multiplo.");

                        int multiple = int.Parse(textBoxParam1.Text);
                        objVector1.SelectMultiple(ref objVector2, multiple);
                        textBoxResults.Text = objVector2.GetNumbers();
                        textBoxRes.Text = objIntNumber1.isMultiple(multiple).ToString();
                        break;
                    case 3:
                        objVector1.SelectSubMultiple(ref objVector2);
                        textBoxResults.Text = objVector2.GetNumbers();
                        textBoxRes.Text = objIntNumber1.isSubMultiple().ToString();
                        break;
                    case 4:
                        objVector1.SelectPrimes(ref objVector2);
                        textBoxResults.Text = objVector2.GetNumbers();
                        textBoxRes.Text = objIntNumber1.isPrime().ToString();
                        break;
                    case 5:
                        objVector1.SelectPalindrome(ref objVector2);
                        textBoxResults.Text = objVector2.GetNumbers();
                        textBoxRes.Text = objIntNumber1.isPalindrome().ToString();
                        break;
                    case 6:
                        objVector1.SelectFibonacci(ref objVector2);
                        textBoxResults.Text = objVector2.GetNumbers();
                        textBoxRes.Text = objIntNumber1.checkIfIsFibonacci().ToString();
                        break;
                    case 7:
                        textBoxRes.Text = objIntNumber1.getFactorial().ToString();
                        break;
                    case 8:
                        textBoxRes.Text = objIntNumber1.isOrder().ToString();
                        break;
                }
            }
            catch (Exception error)
            {
                errorHandler(error.Message);
            }
        }
    }
}

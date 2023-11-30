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

namespace Ithub_WinForm
{
    public partial class Form1 : Form
    {
        int currentPictureNumber = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button1.Enabled = false;
            textBox2.Enabled = false;
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            ChangePicture();

            textBox2.Enabled = true;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                button1.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }

        }

        private void ChangePicture()
        {
            int randomValue = new Random().Next(1, 5);
            currentPictureNumber = randomValue;

            pictureBox1.ImageLocation = @"C:\Users\ilezt\OneDrive\Рабочий стол\pict" + randomValue + ".jpg";
        }

        private void AnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (button1.Text.Length != 0)
            {
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
            }
        }

        private bool IsAnswerCorrect(string answer)
        {
            string[] correctAnswers = { "ламборджини", "тойота", "Лето", "Осень" };

            return correctAnswers[currentPictureNumber - 1] == answer;
        }

        private void Final()
        {
            if (label4.Text == "2")
            {
                MessageBox.Show("Победа");
                Close();
            }
            else if (label6.Text == "2")
            {
                MessageBox.Show("Проигрыш");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IsAnswerCorrect(button1.Text))
            {
                label4.Text = (int.Parse(label4.Text) + 1).ToString();
                button1.Text = "";
                Final();
            }
            else
            {
                label6.Text = (int.Parse(label6.Text) + 1).ToString();
                button1.Text = "";
            }
            ChangePicture();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

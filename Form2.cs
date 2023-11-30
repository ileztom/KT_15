using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KT_15
{
    public partial class Form2 : Form
    {
        int currentPictureNumber = -1;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
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
            int randomValue = new Random().Next(1, 3);
            currentPictureNumber = randomValue;

            pictureBox1.ImageLocation = @"C:\Users\ilezt\OneDrive\Рабочий стол\pict\" + randomValue + ".jpg";
        }

        private void AnswerTextBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
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
                Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text=="ламборджини" & pictureBox1.ImageLocation== @"C:\Users\ilezt\OneDrive\Рабочий стол\pict\2.jpg")
            {
                label4.Text = (int.Parse(label4.Text) + 1).ToString();
                textBox2.Text = "";
                Final();
            }
            if (textBox2.Text == "нисан" & pictureBox1.ImageLocation == @"C:\Users\ilezt\OneDrive\Рабочий стол\pict\1.jpg")
            {
                label4.Text = (int.Parse(label4.Text) + 1).ToString();
                textBox2.Text = "";
                Final();
            }
            else
            {
                label6.Text = (int.Parse(label6.Text) + 1).ToString();
                textBox2.Text = "";
            }
            ChangePicture();
        }
    }
}
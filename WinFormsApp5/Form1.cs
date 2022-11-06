using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int namelen,surnamelen,otchestvolen,sum,count=0;
            
            string name = string.Empty;
            DialogResult result = MessageBox.Show(name = string.Format("Поштарюк Никита Сергеевич"), "Фио", MessageBoxButtons.OK);
            count++;
            namelen= name.Length;
            Text = name;
            string surname = string.Empty;
            MessageBox.Show(surname = string.Format("Занимаюсь кодингом, баскет болом и играю в комп"), "О бо мне", MessageBoxButtons.OK);
            count++;
            surnamelen = surname.Length;
            Text = surname;
            string otchestvo = string.Empty;
            MessageBox.Show(otchestvo = string.Format("Стать как минимум мидл бек енд розроботчиком"), "Цели", MessageBoxButtons.OK);
            count++;
            otchestvolen = otchestvo.Length;
            double average = (namelen + surnamelen + otchestvolen)/3;
            sum = namelen + surnamelen + otchestvolen;
            Text = otchestvo;
            MessageBox.Show($"среднее количество={average},сумма ={sum},количество сообщений={count}", $"Сумирование", MessageBoxButtons.OK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

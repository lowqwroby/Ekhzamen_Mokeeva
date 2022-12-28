using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private bool var;
        public Form1()
        {
            InitializeComponent();
        }

        private void f1()
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            if ((y >= 1 && y > -x + 1) || (x >= 1 && y > -x + 1 && y < 0))
            {
                toolStripStatusLabel1.Text = "Точка находится внутри границ";
                MessageBox.Show("Точка находится внутри границ", "Результат", MessageBoxButtons.OK);
            }
            else if (((y >= 1) || (y >= 1 && y == -x + 1)) || ((x >= 1) || (y < 0 && y > -x + 1)))
            {
                toolStripStatusLabel1.Text = "Точка находтся на границах";
                MessageBox.Show("Точка находтся на границах", "Результат", MessageBoxButtons.OK);
            }
            else
            {
                toolStripStatusLabel1.Text = "Точка находится вне границ";
                MessageBox.Show("Точка находится вне границ", "Результат", MessageBoxButtons.OK);
            }
        }

        private void f2()
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            if ((y > 1 && y > x * x) || (x * x + y * y < 1 && y > x * x) || (x * x + y * y > 1 && y < x * x && y < 1 && y > 0 && y < 1))
            {
                toolStripStatusLabel1.Text = "Точка находится внутри границ";
                MessageBox.Show("Точка находится внутри границ", "Результат", MessageBoxButtons.OK);
            }
            else if((y == 1 && y == x * x) || (x * x + y * y == 1 && y == x * x) || (x * x + y * y >= 1 && y >= x * x && y > 0 && x > 0) || (y == 1 || y == 0))
            {
                toolStripStatusLabel1.Text = "Точка находтся на границах";
                MessageBox.Show("Точка находтся на границах", "Результат", MessageBoxButtons.OK);
            }
            else
            {
                toolStripStatusLabel1.Text = "Точка находится вне границ";
                MessageBox.Show("Точка находится вне границ", "Результат", MessageBoxButtons.OK);
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Height = 506;
                openFileDialog1.Filter = "html files(.html)|*.html|All files(*.*)|*.*";
                openFileDialog1.ShowDialog();
                string name = Path.GetFileName(openFileDialog1.FileName);
                if(name == "1.html")
                {
                    webBrowser1.Navigate(openFileDialog1.FileName);
                    this.Height += 70;
                    var = true;
                }
                else if(name == "2.html")
                {
                    webBrowser1.Navigate(openFileDialog1.FileName);
                    this.Height += 70;
                    var = false;
                }
                else
                {
                    MessageBox.Show("Был открыт неверный файл!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программу создала\nстудентка группы ПКспк-220\nМокеева Дарья Вариант 19\nДата создания: 28.12.2022", "О программе");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(var == true)
                {
                    f1();
                }
                else
                {
                    f2();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введен неверный формат", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("Неизвестная ошибка", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

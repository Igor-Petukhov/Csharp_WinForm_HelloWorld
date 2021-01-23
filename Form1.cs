using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int res; //value for CalcRes Label
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //labelHello.Text = "Привет!";
            try
            {
                res = Convert.ToInt32(labelCalcRes.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Initial value parse error. Set to 10");
                res = 10;
                ShowResult();
            }
        }

        private void buttonSayHello_Click(object sender, EventArgs e)
        {
            if (labelHello.Text == "Привет ")
            {
                labelHello.Text = "  Hello ";
                label1.Text = "World!";
                return;
            }
            if (labelHello.Text == "  Hello ")
            {
                labelHello.Text = "Привет ";
                label1.Text = "мир!";
                return;
            }
        }

        private void buttonDecrement_Click(object sender, EventArgs e)
        {
            res--;
            //labelCalcRes.Text = res.ToString();
            //DRY
            ShowResult();
        }

        private void buttonIncrement_Click(object sender, EventArgs e)
        {
            res++;
            ShowResult();
            Console.WriteLine(labelHello.Text);
        }

        private void ShowResult()
        {
            labelCalcRes.Text = res.ToString();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("До свидания!");
            Close();
        }

        private void buttonSetName_Click(object sender, EventArgs e)
        {
            //Get user name from input (textBox)
            String name = textBoxName.Text;
            //show message
            MessageBox.Show("Hello, " + name);

        }

        private void buttonFillBrief_Click(object sender, EventArgs e)
        {
            // ProjectBrief - форма (класс)
            // projectBrief - обьект (экземпляр)
            ProjectBrief projectBrief = new ProjectBrief();
            // Модальное окно - которое не дает вернуться на родительское
            this.Hide();
            this.Tag ="En";
            projectBrief.ShowDialog(this);
            this.Show(); // ! Если забыть, то приложение "зависает"
        }
    }
}

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
    public partial class ProjectBrief : Form
    {
        
        public ProjectBrief()
        {
            InitializeComponent();
        }

        private void ProjectBrief_Load(object sender, EventArgs e)
        {
            labelLang.Text = Owner.Tag.ToString();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSelectedType.Text = comboBoxType.SelectedItem.ToString();
            CalcPrice();
        }

        private void comboBoxPlatform_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelSelectedPlatform.Text = comboBoxPlatform.SelectedItem.ToString();
            CalcPrice();
        }

        private void CalcPrice()
        {
            int summ = 0;

            if (comboBoxType.SelectedIndex == 0) // Консольное приложение
                summ += 100;
            if (comboBoxType.SelectedIndex == 1) // Оконное приложение
                summ += 200;

            if (comboBoxPlatform.SelectedIndex == 0) // Windows
                summ += 100;
            if (comboBoxPlatform.SelectedIndex == 1) // MacOS
                summ += 300;
            if (comboBoxPlatform.SelectedIndex == 2) // Linux
                summ += 200;

            if (checkBoxSite.Checked) // Web site
                summ += 200;
            if (checkBoxMobileApp.Checked) //Mobile application
                summ += 100;
           
            labelPrice.Text = summ.ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBoxSite_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSite.Checked) // Web site
                labelSite.Text = "Web Сайт";
            else
                labelSite.Text = "";
            CalcPrice();
        }
        private void checkBoxMobileApp_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMobileApp.Checked) //Mobile application
                labelMobileApp.Text = "Мобильное приложение";
            else
                labelMobileApp.Text = "";
            CalcPrice();
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
         int suma = 0;

        public Form1()
        {
            InitializeComponent();
        }
        void PierwszyBlok()
        {
            if (radioButton1.Checked == true)
            {
                suma -= 3;
            }
            else if (radioButton2.Checked == true)
            {
                suma -= 2;
            }
            else if (radioButton3.Checked == true)
            {
                suma -= 1;
            }
            else if (radioButton4.Checked == true)
            {
                suma += 0;
            }
            else if (radioButton5.Checked == true)
            {
                suma += 1;
            }
            else if (radioButton6.Checked == true)
            {
                suma += 2;
            }
            else if (radioButton7.Checked == true)
            {
                suma += 3;
            }
        }
        void DrugiBlok()
        {

            if (radioButton14.Checked == true)
            {
                suma -= 3;
            }
            else if (radioButton13.Checked == true)
            {
                suma -= 2;
            }
            else if (radioButton12.Checked == true)
            {
                suma -= 1;
            }
            else if (radioButton11.Checked == true)
            {
                suma += 0;
            }
            else if (radioButton10.Checked == true)
            {
                suma += 1;
            }
            else if (radioButton9.Checked == true)
            {
                suma += 2;
            }
            else if (radioButton8.Checked == true)
            {
                suma += 3;
            }
        }
        void TrzeciBlok()
        {

            if (radioButton21.Checked == true)
            {
                suma -= 3;
            }
            else if (radioButton20.Checked == true)
            {
                suma -= 2;
            }
            else if (radioButton19.Checked == true)
            {
                suma -= 1;
            }
            else if (radioButton18.Checked == true)
            {
                suma += 0;
            }
            else if (radioButton17.Checked == true)
            {
                suma += 1;
            }
            else if (radioButton16.Checked == true)
            {
                suma += 2;
            }
            else if (radioButton15.Checked == true)
            {
                suma += 3;
            }
        }
        void CzwartyBlok()
        {
            if (radioButton28.Checked == true)
            {
                suma -= 3;
            }
            else if (radioButton27.Checked == true)
            {
                suma -= 2;
            }
            else if (radioButton26.Checked == true)
            {
                suma -= 1;
            }
            else if (radioButton25.Checked == true)
            {
                suma += 0;
            }
            else if (radioButton24.Checked == true)
            {
                suma += 1;
            }
            else if (radioButton23.Checked == true)
            {
                suma += 2;
            }
            else if (radioButton22.Checked == true)
            {
                suma += 3;
            }
        }
        void PiatyBlok()
        {
            if (radioButton35.Checked == true)
            {
                suma -= 3;
            }
            else if (radioButton34.Checked == true)
            {
                suma -= 2;
            }
            else if (radioButton33.Checked == true)
            {
                suma -= 1;
            }
            else if (radioButton32.Checked == true)
            {
                suma += 0;
            }
            else if (radioButton31.Checked == true)
            {
                suma += 1;
            }
            else if (radioButton30.Checked == true)
            {
                suma += 2;
            }
            else if (radioButton29.Checked == true)
            {
                suma += 3;
            }
        }
        void Zlicz()
        {
            PierwszyBlok();
            DrugiBlok();
            TrzeciBlok();
            CzwartyBlok();
            PiatyBlok();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Zlicz();
            button1.Visible = false;
            
            wynik wynik = new wynik(suma);

            wynik.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }   
    
}

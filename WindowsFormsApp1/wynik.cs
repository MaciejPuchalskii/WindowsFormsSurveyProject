using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class wynik : Form
    {
        int sumaa;

        public wynik(int number)
        {
            InitializeComponent();
            sumaa = number;
            zaladujobrazitekst();
        }
        public wynik(int number, string Author)
        {
            InitializeComponent();
            sumaa = number;
            zaladujobrazitekst();
            AutorInsert.Text = Author;
            Autor.Visible = true;
            label2.Visible = true; 
        }
        string[] opisyHumoru =
        {
            "You are really sad, better go to specialist.. :( ",
            "You sad, watch some Kunf Fu Pandas Movies ;) ",
            "For sure u need to find something that will make u happier.",
            "You are good man, you happy, go, live is good!",
            "Amazing u giga chad!"
        };
        string[] pliki = { "verysad.png","sad.png","neutral.png","ok.png","giga.png" };

        void zaladujobrazitekst()
        {
            if(sumaa >= -15 && sumaa <-9)
            {
                label1.Text = opisyHumoru[0];
                pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory +@"\Images\" + pliki[0]);
            }
            else if(sumaa >= -9 && sumaa <-3)
            {
                label1.Text = opisyHumoru[1];
                pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Images\" + pliki[1]);
            }
            else if(sumaa >= -3 && sumaa <3)
            {
                label1.Text = opisyHumoru[2];
                pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Images\" + pliki[2]);
            }
            else if(sumaa >=3 && sumaa <9)
            {
                label1.Text = opisyHumoru[3];
                pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Images\" + pliki[3]);
            }
            else if (sumaa >= 9 && sumaa <= 15)
            {
                label1.Text = opisyHumoru[4];
                pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\Images\" + pliki[4]);

            }

        }

        private void EXIT_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Close();
        }

    }
}

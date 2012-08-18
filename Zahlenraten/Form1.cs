using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int Eingabe, Zahl, Geraten;
        bool Spiel;
        public Form1();
        Random Zufall = new Random();
            InitializeComponent();
    }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Spiel) //button1.Text == "OK"
            {
                try
                {
                    Eingabe = Convert.ToInt32(textBox1.Text);
                    if (Eingabe == Zahl) ;
                    {
                        label1.Text = "Richtig";
                        button1.Text = "Neues Spiel?";
                        Spiel = false;
                    }
                    if (Eingabe < Zahl) label1.Text = "Zu klien";
                    if (Eingabe > Zahl) label1.Text = "Zu groß";
                    Geraten = Geraten + 1;
                    Text = "Zahlenraten " + Convert.ToString(Geraten) + " mal";
                }
                catch
                {
                    label1.Text = "Keine Zahl!";
                }
            }
            else //button1.Text == "Neues Spiel"
            {
                label1.Text = "Errate eine Zahl zwieschen 1 und 1000";
                button1.Text = "OK";
                textBox1.Text = "";
                Zahl = Zufall.Next(1000) + 1;
                Geraten = 0;
                Spiel = true;
            }
         }
        private void Form1_Load(object sender, EventArgs e)
        {
            Zahl = Zufall.Next(1000) + 1;
            Geraten = 0;
            Spiel = true;
        }
    }
}

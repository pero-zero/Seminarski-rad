using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace udaljenost_između_dviju_točaka
{
    public partial class Form1 : Form
    {
        int x_start=0, y_start=0;
        int x_kraj=0, y_kraj=0;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Koordinatni_sustav_MouseDown(object sender, MouseEventArgs e)
        {            
            if (e.Button == MouseButtons.Left)
            {
                x_start = e.X;
                y_start = e.Y;
                X1_koordianta.Text = x_start.ToString();
                Y1_koordinata.Text = y_start.ToString();
                Crtaj(true, false);
            }            
        }

        private void Koordinatni_sustav_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x_kraj = e.X;
                y_kraj = e.Y;
                double rezultat = Math.Sqrt(Math.Pow(x_kraj - x_start, 2) + Math.Pow(y_kraj - y_start, 2));
                Y2_koordinata.Text = y_kraj.ToString();
                X2_koordinata.Text = x_kraj.ToString();
                Udaljenost_koordinata.Text = rezultat.ToString();
                Crtaj(false, true);
                x_start = 0;
                y_start = 0;
                x_kraj = 0;
                y_kraj = 0;
            }
        }

        private void Koordinatni_sustav_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void Crtaj(bool mouse_down, bool mouse_up)
        {
            Graphics graf = Koordinatni_sustav.CreateGraphics();
            Pen olovka = new Pen(Color.Black);


            if (mouse_down == true && mouse_up == false)
            {
                graf.Clear(Color.White);
                graf.DrawLine(olovka, x_start + 5, y_start + 5, x_start - 5, y_start - 5);
                graf.DrawLine(olovka, x_start - 5, y_start + 5, x_start + 5, y_start - 5);
            }
            else if (mouse_down == false && mouse_up == true)
            {
                graf.DrawLine(olovka, x_kraj + 5, y_kraj + 5, x_kraj - 5, y_kraj - 5);
                graf.DrawLine(olovka, x_kraj - 5, y_kraj + 5, x_kraj + 5, y_kraj - 5);
                
            }
            
            
        }

        
    }
}

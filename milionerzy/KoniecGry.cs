using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace milionerzy
{
    public partial class KoniecGry : UserControl
    {
        public KoniecGry(String nick, String wynik, String pytanie, String koła)
        {
            InitializeComponent();
            nickLabel.Text = "Nick: " + nick;
            wynikLabel.Text = "Wynik: " + wynik;
            pytanieLabel.Text = "Ostatnie Pytanie: " + pytanie;
            kołaLabel.Text = koła;      
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

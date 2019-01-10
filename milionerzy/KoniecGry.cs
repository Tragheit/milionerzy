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
        public KoniecGry(String nick, String wynik, int pytanie, String koła)
        {
            InitializeComponent();
            updateLifebuoys(koła);

            nickLabel.Text = "Nick: " + nick;
            wynikLabel.Text = "Wynik: " + wynik;
            pytanieLabel.Text = "Ostatnie Pytanie: " + pytanie;

        }

        public void zacznijOdNowaClicked(object sender, EventArgs e)
        {
            var temp = new MenuGlowne();
            temp.Parent = this;
            temp.Dock = DockStyle.Fill;
            temp.BringToFront();
        }

        private void updateLifebuoys(string koła)
        {
            if (koła.Contains("TE"))
                telefonPB.BackgroundImage = Properties.Resources.endPhoneX;
            if (koła.Contains("PU"))
                publikaPB.BackgroundImage = Properties.Resources.endPeopleX;
            if (koła.Contains("PP"))
                polowaPB.BackgroundImage = Properties.Resources.end50X;
        }
    }
}

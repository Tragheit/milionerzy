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
    public partial class NowaGra : UserControl
    {
        private Random rnd = new Random();
        private string nickGracza;
        private int nrPytania = 0;
        private int roundCounter = 1;
        string kola = "";

        public NowaGra(string Nick)
        {
            InitializeComponent();
            nickGracza = Nick;
            startRound();
        }

        private void startRound() {
            if (roundCounter++ > 8) {
            displayYouWin();
            }

            this.Update();

            int index = rnd.Next(1, 20);

            using (JiPP2018Z502Entities jippEntities = new JiPP2018Z502Entities())
            {
                Pytania pytania = jippEntities.Pytania.Single(a => a.Id == index);

                pytanieLabel.Text = pytania.Tresc;
                odpAButton.Text = pytania.Poprawna_odpowiedz;
                odpBButton.Text = pytania.Falszywa_odpowiedz_1;
                odpCButton.Text = pytania.Falszywa_odpowiedz_2;
                odpDButton.Text = pytania.Falszywa_odpowiedz_3;
            };
            clearAnswers();
        }

        private void correctAnswerSelected(object sender, EventArgs e) {
            odpAButton.BackColor = Color.Green;
            nrPytania++;
            listaPytań1.changeRate(nrPytania);
            listaPytań1.Refresh();
            
            startRound();
        }

        private void incorrectAnswerSelected(object sender, EventArgs e) {
            gameOver(nickGracza, listaPytań1.GetWynik(), nrPytania);
        }

        private void rezygnujClicked(object sender, EventArgs e)
        {
            gameOver(nickGracza, listaPytań1.GetWynik(), nrPytania);
        }

        private void TelefonKoloClicked(object sender, EventArgs e) {
            kola += "TE";
            telefonButton.Enabled = false;
            telefonButton.BackgroundImage = Properties.Resources.telefon_uzyte;

            var nieOdbiera = new NieOdbiera();
            nieOdbiera.Parent = this;
            nieOdbiera.Dock = DockStyle.Fill;
            nieOdbiera.BringToFront();
        }

        private void pulicznoscKoloClicked(object sender, EventArgs e) {
            kola += "PU";
            publicznoscButton.Enabled = false;
            publicznoscButton.BackgroundImage = Properties.Resources.publika_uzyte;

            askAudience();
        }

        private void polNaPolKoloClicked(object sender, EventArgs e) {
            kola += "PP";
            polowaButton.Enabled = false;
            polowaButton.BackgroundImage = Properties.Resources._5050_uzyte;

            int index = rnd.Next(1, 3);
            switch (index)
            {
                case 1:
                    odpBButton.BackColor = Color.Gray;
                    odpBButton.Enabled = false;
              
                    odpCButton.BackColor = Color.Gray;
                    odpCButton.Enabled = false;
                    break;
                case 2:
                    odpCButton.BackColor = Color.Gray;
                    odpCButton.Enabled = false;

                    odpDButton.BackColor = Color.Gray;
                    odpDButton.Enabled = false;
                    break;
                case 3:
                    odpBButton.BackColor = Color.Gray;
                    odpBButton.Enabled = false;

                    odpDButton.BackColor = Color.Gray;
                    odpDButton.Enabled = false;
                    break;
            }
        }

        private void clearAnswers()
        {
            foreach (Control e in tableLayoutPanel2.Controls.OfType<Button>())
            {
                e.BackColor = Color.MidnightBlue;
                e.Enabled = true;
                e.ForeColor = Color.Gold;
            }

            foreach (Control e in tableLayoutPanel2.Controls.OfType<ProgressBar>())
            {
                e.Visible = false;
            }
        }

        private void displayYouWin()
        {
            var wygrana = new Wygrana(nickGracza);
            wygrana.Parent = this;
            wygrana.Dock = DockStyle.Fill;
            wygrana.BringToFront();

            WaitNSeconds(3);

            gameOver(nickGracza, listaPytań1.GetWynik(), nrPytania);
        }

        private void gameOver(String nick, int wynik, int numerPytania)
        {
            var koniecGry = new KoniecGry(nick, listaPytań1.showAward(), numerPytania, kola);
            koniecGry.Parent = this;
            koniecGry.Dock = DockStyle.Fill;
            koniecGry.BringToFront();

            int[] wyniki = new int[] {0, 250, 2500, 20000, 100000, 250000, 500000, 1000000}; 

            using (JiPP2018Z502Entities jippEntities = new JiPP2018Z502Entities())
            {
                Historia_Gier entity = new Historia_Gier(nick, wyniki[wynik], checkUsedLifeBuoys(), nrPytania);
                jippEntities.Historia_Gier.Add(entity);
                jippEntities.SaveChanges();
            };
        }

        private void askAudience()
        {
            foreach (Control e in tableLayoutPanel2.Controls.OfType<ProgressBar>())
            {
                e.Visible = true;
            }
                

            Random rnd = new Random();
            int luckyDiceRoll = rnd.Next(1, 10);

            switch (luckyDiceRoll)
            {
                case 1:
                    setBarValues(60, 10, 20, 10);
                    break;
                case 2:
                    setBarValues(10, 45, 15, 30);
                    break;
                case 3:
                    setBarValues(70, 0, 10, 20);
                    break;
                case 4:
                    setBarValues(55, 20, 10, 15);
                    break;
                case 5:
                    setBarValues(5, 10, 15, 70);
                    break;
                case 6:
                    setBarValues(80, 5, 2, 13);
                    break;
                case 7:
                    setBarValues(90, 5, 2, 3);
                    break;
                case 8:
                    setBarValues(99, 1, 0, 0);
                    break;
                case 9:
                    setBarValues(0, 0, 90, 10);
                    break;
                case 10:
                    setBarValues(44, 16, 25, 25);
                    break;
            }
        }

        private void setBarValues(int a, int b, int c, int d)
        {
            PBA.Increment(a);
            PBB.Increment(b);
            PBC.Increment(c);
            PBD.Increment(d);
        }

        private int checkUsedLifeBuoys() {
            int result = 0;

            if (kola.Contains("TE"))
                result++;
            if (kola.Contains("PU"))
                result++;
            if (kola.Contains("PP"))
                result++;

            return result;       
        }

        private void WaitNSeconds(int seconds)
        {
            if (seconds < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(seconds);
            while (DateTime.Now < _desired)
            {
                Application.DoEvents();
            }
        }

    }
}

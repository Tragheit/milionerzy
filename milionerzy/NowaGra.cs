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
        private String nickGracza;
        private int nrPytania = 0;
        private int roundCounter = 1;

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
            gameOver(nickGracza, listaPytań1.GetWynik(), nrPytania.ToString(), "kola");
        }

        private void clearAnswers()
        {
            foreach (Control e in tableLayoutPanel2.Controls.OfType<Button>())
                e.BackColor = Color.MidnightBlue;
        }

        private void displayYouWin()
        {
            var wygrana = new Wygrana(nickGracza);
            wygrana.Parent = this;
            wygrana.Dock = DockStyle.Fill;
            wygrana.BringToFront();

            WaitNSeconds(3);

            gameOver(nickGracza, listaPytań1.GetWynik(), nrPytania.ToString(), "kola");
        }

        private void rezygnujClicked()
        {
            gameOver(nickGracza, listaPytań1.GetWynik(), nrPytania.ToString(), "kola");
        }

        private void gameOver(String nick, String wynik, string numerPytania, String koła)
        {
            var koniecGry = new KoniecGry(nick, wynik, numerPytania, koła);
            koniecGry.Parent = this;
            koniecGry.Dock = DockStyle.Fill;
            koniecGry.BringToFront();
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

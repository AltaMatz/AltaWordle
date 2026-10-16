using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace AltaWordle
{
    public partial class Home : Form
    {

        private WordManager wordManager = new WordManager();
        private string language = "Italiano (IT)";

        public Home()
        {
            InitializeComponent();
            settingsButton.BringToFront();
            langSelect.SelectedIndex = 0;
            // Controllare in qualsiasi momento il cambio di lingua e inserire nelle liste le parole dei .txt corrispondenti
        }

        private void langSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (langSelect.SelectedItem?.ToString() != null)
            {
                language = langSelect.SelectedItem?.ToString();
            }
            int ris = wordManager.LoadWords(language);
            refreshLanguage(ris);
        }


        private void refreshLanguage(int ris)
        {
            if (ris == 1)
            {
                hostPlayButton.Text = "Gioca come\nOspite";
                playerPlayButton.Text = "Seleziona\nProfilo";
                rulesButton.Text = "Leggi le\nRegole";
                statsButton.Text = "Statistiche\nGenerali";
                exitButton.Text = "Esci";
                langSelect.Text = "Lingua";
            }
            else if (ris == 2)
            {
                hostPlayButton.Text = "Play as\nGuest";
                playerPlayButton.Text = "Select\nProfile";
                rulesButton.Text = "Read the\nRules";
                statsButton.Text = "General\nStatistics";
                exitButton.Text = "Exit";
                langSelect.Text = "Language";
            }
            else if (ris == 3)
            {
                hostPlayButton.Text = "Jouer tout\nde suite";
                playerPlayButton.Text = "Sélectionner\nProfil";
                rulesButton.Text = "Lire les\nRègles";
                statsButton.Text = "Statistiques\nGénérales";
                exitButton.Text = "Quitter";
                langSelect.Text = "Langue";
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            if (settingsMenu.Visible == false)  // Quando apro il menu, ridimensiono e sposto gli altri elementi e coloro l'icona settings
            {
                settingsMenu.Visible = true;
                settingsButton.BackColor = Color.FromArgb(10, 10, 10);
                homeLayoutPanel.Location = new Point(268, 204);
                homeLayoutPanel.Size = new Size(565, 600);
                title.Location = new Point(268, 25);
                title.Size = new Size(565, 113);
            }
            else                                // Quando chiudo il menu, ripristino le dimensioni e i colori originali
            {
                settingsMenu.Visible = false;
                settingsButton.BackColor = BackColor;
                homeLayoutPanel.Location = new Point(49, 204);
                homeLayoutPanel.Size = new Size(784, 600);
                title.Location = new Point(49, 25);
                title.Size = new Size(784, 113);
            }
        }

        private void hostPlayButton_Click(object sender, EventArgs e)   // Partita come ospite
        {
            matchPanel.BringToFront();
            titleAlternative.BringToFront();
            // Scelta difficoltà (FACILE, MEDIO, DIFFICILE) - devo ancora dividere parole in più liste, ultima implementazione
            // Richiamo la funzione LoadWords()
            // In base alla difficoltà, seleziono da una lista "guess" una parola casuale con GetGuessWord()

            // LETTERA INDOVINATA = Verde | LETTERA PRESENTE MA POSIZIONE DIVERSA = Giallo | LETTERA SBAGLIATA = Grigio

            /* CONTROLLI:
            - Prima controllo che la parola esista (appartenga alla lista validWords), e poi comparo le lettere
            - Se una lettera SINGOLA è inserita correttamente (VERDE) ma nel tentativo è presente più volte, quest'ultima non viene colorata di giallo ma di grigio
            - Se invece è presente più volte allora coloro normalmente di giallo 
            - Massimo 6 tentativi per indovinare la parola
            */

            // Se la parola viene indovinata (tutte le caselle verdi) allora viene mostrata la scritta "Vittoria!" e i pulsanti "Gioca di nuovo" e "Home"
            // Se la parola non viene indovinata, allora viene mostrata la scritta "Sconfitta!" e i due pulsanti
        }

        private void playerPlayButton_Click(object sender, EventArgs e) // Partita come giocatore loggato
        {
            // Schermata di Login con nome utente e password e tasto per la registrazione (con controllo di non ripetizione nome utente)
            // Mostrare le difficoltà giocabili, le statistiche del giocatore e tutte le info modificabili sul profilo
        }

        private void rulesButton_Click(object sender, EventArgs e)      // Interfaccia con regolamento AltaWordle
        {
            // Mostrare le regole del gioco (significato colori caselle...)
        }

        private void statsButton_Click(object sender, EventArgs e)      // Interfaccia con statistiche partite totali
        {
            // Mostrare statistiche (probabile utilizzo di ProgressBar per percentuali) con vittorie, sconfitte, tentativi medi
            // Se loggato, mostrare anche le statistiche personali (con possibilità di reset)
        }

        private void langSelect_DropDown(object sender, EventArgs e)
        {
            exitButton.Location = new Point(40, 305);
        }

        private void langSelect_DropDownClosed(object sender, EventArgs e)
        {
            exitButton.Location = new Point(40, 224);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitButton_MouseEnter(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.FromArgb(31, 31, 31);
        }

        private void exitButton_MouseExit(object sender, EventArgs e)
        {
            exitButton.BackColor = Color.FromArgb(10, 10, 10);
        }

        private void letter1_1_TextChanged(object sender, EventArgs e)
        {
            if (letter1_1.Text.Length == 1)
            {
                letter1_2.Focus();
            }
        }

        private void letter1_2_TextChanged(object sender, EventArgs e)
        {
            if (letter1_2.Text.Length == 1)
            {
                letter1_3.Focus();
            }
            else if (letter1_2.Text.Length == 0)
            {
                letter1_1.Focus();
            }
        }

        private void letter1_3_TextChanged(object sender, EventArgs e)
        {
            if (letter1_3.Text.Length == 1)
            {
                letter1_4.Focus();
            }
            else if (letter1_3.Text.Length == 0)
            {
                letter1_2.Focus();
            }
        }

        private void letter1_4_TextChanged(object sender, EventArgs e)
        {
            if (letter1_4.Text.Length == 1)
            {
                letter1_5.Focus();
            }
            else if (letter1_4.Text.Length == 0)
            {
                letter1_3.Focus();
            }
        }

        private void letter1_5_TextChanged(object sender, EventArgs e)
        {
            if (letter1_5.Text.Length == 0)
            {
                letter1_4.Focus();
            }
        }

        public class WordManager
        {
            private List<string> guessWords = new List<string>();
            private List<string> validWords = new List<string>();

            public int LoadWords(string language)
            {
                if (language == "Italiano (IT)")
                {
                    //guessWords = new List<string>(File.ReadAllLines("guess_words.txt"));
                    //validWords = new List<string>(File.ReadAllLines("valid_words.txt"));
                    return 1;
                }
                else if (language == "Inglese (EN)")
                {
                    //guessWords = new List<string>(File.ReadAllLines("guess_words_EN.txt"));
                    //validWords = new List<string>(File.ReadAllLines("valid_words_EN.txt"));
                    return 2;
                }
                else if (language == "Francese (FR)")
                {
                    //guessWords = new List<string>(File.ReadAllLines("guess_words_FR.txt"));
                    //validWords = new List<string>(File.ReadAllLines("valid_words_FR.txt"));
                    return 3;
                }
                return 0;
            }

            public string GetGuessWord()
            {
                if (guessWords.Count == 0)
                {
                    return "PROVA";     // Se la lista è vuota, c'è stato qualche errore e restituisco la parola PROVA
                }
                Random random = new Random();
                int indice = random.Next(0, guessWords.Count);  // INTERVALLO: Da 0 a (N parole - 1)
                return guessWords[indice].ToUpper();     // In maiuscolo per evitare scocciature
            }
        }

        private void letter2_1_TextChanged(object sender, EventArgs e)
        {
            if (letter2_1.Text.Length == 1)
            {
                letter2_2.Focus();
            }
        }

        private void letter2_2_TextChanged(object sender, EventArgs e)
        {
            if (letter2_2.Text.Length == 1)
            {
                letter2_3.Focus();
            }
            else if (letter2_2.Text.Length == 0)
            {
                letter2_1.Focus();
            }
        }

        private void letter2_3_TextChanged(object sender, EventArgs e)
        {
            if (letter2_3.Text.Length == 1)
            {
                letter2_4.Focus();
            }
            else if (letter2_3.Text.Length == 0)
            {
                letter2_2.Focus();
            }
        }

        private void letter2_4_TextChanged(object sender, EventArgs e)
        {
            if (letter2_4.Text.Length == 1)
            {
                letter2_5.Focus();
            }
            else if (letter2_4.Text.Length == 0)
            {
                letter2_3.Focus();
            }
        }

        private void letter2_5_TextChanged(object sender, EventArgs e)
        {
            if (letter2_5.Text.Length == 0)
            {
                letter2_4.Focus();
            }
        }
    }
}

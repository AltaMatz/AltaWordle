using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace AltaWordle
{
    public partial class Home : Form
    {

        private WordManager wordManager = new WordManager();
        private string language = "Italiano (IT)";
        private string insertedText = "";

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


        private void refreshLanguage(int ris)                           // Traduzione pulsanti e label
        {
            if (ris == 1)
            {
                hostPlayButton.Text = "Gioca come\nOspite";
                playerPlayButton.Text = "Seleziona\nProfilo";
                rulesButton.Text = "Leggi le\nRegole";
                statsButton.Text = "Statistiche\nGenerali";
                exitButton.Text = "Esci";
                langSelect.Text = "Lingua";
                enterButton.Text = "CONFERMA";
                deleteButton.Text = "CANCELLA";
            }
            else if (ris == 2)
            {
                hostPlayButton.Text = "Play as\nGuest";
                playerPlayButton.Text = "Select\nProfile";
                rulesButton.Text = "Read the\nRules";
                statsButton.Text = "General\nStatistics";
                exitButton.Text = "Exit";
                langSelect.Text = "Language";
                enterButton.Text = "ENTER";
                deleteButton.Text = "DELETE";
            }
            else if (ris == 3)
            {
                hostPlayButton.Text = "Jouer tout\nde suite";
                playerPlayButton.Text = "Sélectionner\nProfil";
                rulesButton.Text = "Lire les\nRègles";
                statsButton.Text = "Statistiques\nGénérales";
                exitButton.Text = "Quitter";
                langSelect.Text = "Langue";
                enterButton.Text = "ENTRER";
                deleteButton.Text = "SUPPRIMER";
            }
        }

        private void settingsButton_Click(object sender, EventArgs e)   // Apertura menu laterale e spostamento oggetti
        {
            if (settingsPanel.Visible == false)  // Quando apro il menu, ridimensiono e sposto gli altri elementi e coloro l'icona settings
            {
                settingsPanel.Visible = true;
                settingsButton.BackColor = Color.FromArgb(10, 10, 10);
                homeLayoutPanel.Location = new Point(268, 204);
                homeLayoutPanel.Size = new Size(565, 600);
                title.Location = new Point(268, 25);
                title.Size = new Size(565, 113);
                firstWordPanel.Location = new Point(307, 148);
                secondWordPanel.Location = new Point(307, 250);
                thirdWordPanel.Location = new Point(307, 352);
                fourthWordPanel.Location = new Point(307, 454);
                fifthWordPanel.Location = new Point(307, 556);
                sixthWordPanel.Location = new Point(307, 658);
                enterButton.Location = new Point(307, 764);
                deleteButton.Location = new Point(547, 764);
            }
            else                                // Quando chiudo il menu, ripristino le dimensioni e i colori originali
            {
                settingsPanel.Visible = false;
                settingsButton.BackColor = BackColor;
                homeLayoutPanel.Location = new Point(49, 204);
                homeLayoutPanel.Size = new Size(784, 600);
                title.Location = new Point(49, 25);
                title.Size = new Size(784, 113);
                firstWordPanel.Location = new Point(200, 148);
                secondWordPanel.Location = new Point(200, 250);
                thirdWordPanel.Location = new Point(200, 352);
                fourthWordPanel.Location = new Point(200, 454);
                fifthWordPanel.Location = new Point(200, 556);
                sixthWordPanel.Location = new Point(200, 658);
                enterButton.Location = new Point(200, 764);
                deleteButton.Location = new Point(440, 764);
            }
        }

        private void hostPlayButton_Click(object sender, EventArgs e)   // Partita come ospite
        {
            matchPanel.BringToFront();
            title.BringToFront();
            settingsPanel.BringToFront();
            settingsButton.BringToFront();
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
            insertedText = letter1_1.Text;
            if (insertedText.Length == 2)
            {
                char firstChar = insertedText[0];
                char secondChar = insertedText[1];
                letter1_1.Text = firstChar.ToString();
                letter1_2.Text = secondChar.ToString();
                letter1_2.Focus();
                letter1_2.SelectionStart = letter1_2.Text.Length;
                letter1_2.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter1_2_TextChanged(object sender, EventArgs e)
        {
            insertedText = letter1_2.Text;
            if (insertedText.Length == 2)
            {
                char firstChar = insertedText[0];
                char secondChar = insertedText[1];
                letter1_2.Text = firstChar.ToString();
                letter1_3.Text = secondChar.ToString();
                letter1_3.Focus();
                letter1_3.SelectionStart = letter1_3.Text.Length;
                letter1_3.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
            else if (letter1_2.Text.Length == 0)
            {
                letter1_1.Focus();
                letter1_1.SelectionStart = letter1_1.Text.Length;
                letter1_1.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter1_3_TextChanged(object sender, EventArgs e)
        {
            insertedText = letter1_3.Text;
            if (insertedText.Length == 2)
            {
                char firstChar = insertedText[0];
                char secondChar = insertedText[1];
                letter1_3.Text = firstChar.ToString();
                letter1_4.Text = secondChar.ToString();
                letter1_4.Focus();
                letter1_4.SelectionStart = letter1_4.Text.Length;
                letter1_4.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
            else if (letter1_3.Text.Length == 0)
            {
                letter1_2.Focus();
                letter1_2.SelectionStart = letter1_2.Text.Length;
                letter1_2.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter1_4_TextChanged(object sender, EventArgs e)
        {
            insertedText = letter1_4.Text;
            if (insertedText.Length == 2)
            {
                char firstChar = insertedText[0];
                char secondChar = insertedText[1];
                letter1_4.Text = firstChar.ToString();
                letter1_5.Text = secondChar.ToString();
                letter1_5.Focus();
                letter1_5.SelectionStart = letter1_5.Text.Length;
                letter1_5.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
            else if (letter1_4.Text.Length == 0)
            {
                letter1_3.Focus();
                letter1_3.SelectionStart = letter1_3.Text.Length;
                letter1_3.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter1_5_TextChanged(object sender, EventArgs e)
        {
            if (letter1_5.Text.Length == 0)
            {
                letter1_4.Focus();
                letter1_4.SelectionStart = letter1_4.Text.Length;
                letter1_4.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
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
            insertedText = letter2_1.Text;
            if (insertedText.Length == 2)
            {
                char firstChar = insertedText[0];
                char secondChar = insertedText[1];
                letter2_1.Text = firstChar.ToString();
                letter2_2.Text = secondChar.ToString();
                letter2_2.Focus();
                letter2_2.SelectionStart = letter2_2.Text.Length;
                letter2_2.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter2_2_TextChanged(object sender, EventArgs e)
        {
            insertedText = letter2_2.Text;
            if (insertedText.Length == 2)
            {
                char firstChar = insertedText[0];
                char secondChar = insertedText[1];
                letter2_2.Text = firstChar.ToString();
                letter2_3.Text = secondChar.ToString();
                letter2_3.Focus();
                letter2_3.SelectionStart = letter2_3.Text.Length;
                letter2_3.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
            else if (letter2_2.Text.Length == 0)
            {
                letter2_1.Focus();
                letter2_1.SelectionStart = letter2_1.Text.Length;
                letter2_1.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter2_3_TextChanged(object sender, EventArgs e)
        {
            insertedText = letter2_3.Text;
            if (insertedText.Length == 2)
            {
                char firstChar = insertedText[0];
                char secondChar = insertedText[1];
                letter2_3.Text = firstChar.ToString();
                letter2_4.Text = secondChar.ToString();
                letter2_4.Focus();
                letter2_4.SelectionStart = letter2_4.Text.Length;
                letter2_4.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
            else if (letter2_3.Text.Length == 0)
            {
                letter2_2.Focus();
                letter2_2.SelectionStart = letter2_2.Text.Length;
                letter2_2.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter2_4_TextChanged(object sender, EventArgs e)
        {
            insertedText = letter2_4.Text;
            if (insertedText.Length == 2)
            {
                char firstChar = insertedText[0];
                char secondChar = insertedText[1];
                letter2_4.Text = firstChar.ToString();
                letter2_5.Text = secondChar.ToString();
                letter2_5.Focus();
                letter2_5.SelectionStart = letter2_5.Text.Length;
                letter2_5.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
            else if (letter2_4.Text.Length == 0)
            {
                letter2_3.Focus();
                letter2_3.SelectionStart = letter2_3.Text.Length;
                letter2_3.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter2_5_TextChanged(object sender, EventArgs e)
        {
            if (letter2_5.Text.Length == 0)
            {
                letter2_4.Focus();
                letter2_4.SelectionStart = letter2_4.Text.Length;
                letter2_4.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter3_1_TextChanged(object sender, EventArgs e)
        {
            insertedText = letter3_1.Text;
            if (insertedText.Length == 2)
            {
                char firstChar = insertedText[0];
                char secondChar = insertedText[1];
                letter3_1.Text = firstChar.ToString();
                letter3_2.Text = secondChar.ToString();
                letter3_2.Focus();
                letter3_2.SelectionStart = letter3_2.Text.Length;
                letter3_2.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter3_2_TextChanged(object sender, EventArgs e)
        {
            insertedText = letter3_2.Text;
            if (insertedText.Length == 2)
            {
                char firstChar = insertedText[0];
                char secondChar = insertedText[1];
                letter3_2.Text = firstChar.ToString();
                letter3_3.Text = secondChar.ToString();
                letter3_3.Focus();
                letter3_3.SelectionStart = letter3_3.Text.Length;
                letter3_3.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
            else if (letter3_2.Text.Length == 0)
            {
                letter3_1.Focus();
                letter3_1.SelectionStart = letter3_1.Text.Length;
                letter3_1.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter3_3_TextChanged(object sender, EventArgs e)
        {
            insertedText = letter3_3.Text;
            if (insertedText.Length == 2)
            {
                char firstChar = insertedText[0];
                char secondChar = insertedText[1];
                letter3_3.Text = firstChar.ToString();
                letter3_4.Text = secondChar.ToString();
                letter3_4.Focus();
                letter3_4.SelectionStart = letter3_4.Text.Length;
                letter3_4.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
            else if (letter3_3.Text.Length == 0)
            {
                letter3_2.Focus();
                letter3_2.SelectionStart = letter3_2.Text.Length;
                letter3_2.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter3_4_TextChanged(object sender, EventArgs e)
        {
            insertedText = letter3_4.Text;
            if (insertedText.Length == 2)
            {
                char firstChar = insertedText[0];
                char secondChar = insertedText[1];
                letter3_4.Text = firstChar.ToString();
                letter3_5.Text = secondChar.ToString();
                letter3_5.Focus();
                letter3_5.SelectionStart = letter3_5.Text.Length;
                letter3_5.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
            else if (letter3_4.Text.Length == 0)
            {
                letter3_3.Focus();
                letter3_3.SelectionStart = letter3_3.Text.Length;
                letter3_3.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter3_5_TextChanged(object sender, EventArgs e)
        {
            if (letter3_5.Text.Length == 0)
            {
                letter3_4.Focus();
                letter3_4.SelectionStart = letter3_4.Text.Length;
                letter3_4.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter4_1_TextChanged(object sender, EventArgs e)
        {
            insertedText = letter4_1.Text;
            if (insertedText.Length == 2)
            {
                char firstChar = insertedText[0];
                char secondChar = insertedText[1];
                letter4_1.Text = firstChar.ToString();
                letter4_2.Text = secondChar.ToString();
                letter4_2.Focus();
                letter4_2.SelectionStart = letter4_2.Text.Length;
                letter4_2.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter4_2_TextChanged(object sender, EventArgs e)
        {
            insertedText = letter4_2.Text;
            if (insertedText.Length == 2)
            {
                char firstChar = insertedText[0];
                char secondChar = insertedText[1];
                letter4_2.Text = firstChar.ToString();
                letter4_3.Text = secondChar.ToString();
                letter4_3.Focus();
                letter4_3.SelectionStart = letter4_3.Text.Length;
                letter4_3.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
            else if (letter4_2.Text.Length == 0)
            {
                letter4_1.Focus();
                letter4_1.SelectionStart = letter4_1.Text.Length;
                letter4_1.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter4_3_TextChanged(object sender, EventArgs e)
        {
            insertedText = letter4_3.Text;
            if (insertedText.Length == 2)
            {
                char firstChar = insertedText[0];
                char secondChar = insertedText[1];
                letter4_3.Text = firstChar.ToString();
                letter4_4.Text = secondChar.ToString();
                letter4_4.Focus();
                letter4_4.SelectionStart = letter4_4.Text.Length;
                letter4_4.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
            else if (letter4_3.Text.Length == 0)
            {
                letter4_2.Focus();
                letter4_2.SelectionStart = letter4_2.Text.Length;
                letter4_2.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter4_4_TextChanged(object sender, EventArgs e)
        {
            insertedText = letter4_4.Text;
            if (insertedText.Length == 2)
            {
                char firstChar = insertedText[0];
                char secondChar = insertedText[1];
                letter4_4.Text = firstChar.ToString();
                letter4_5.Text = secondChar.ToString();
                letter4_5.Focus();
                letter4_5.SelectionStart = letter4_5.Text.Length;
                letter4_5.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
            else if (letter4_4.Text.Length == 0)
            {
                letter4_3.Focus();
                letter4_3.SelectionStart = letter4_3.Text.Length;
                letter4_3.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter4_5_TextChanged(object sender, EventArgs e)
        {
            if (letter4_5.Text.Length == 0)
            {
                letter4_4.Focus();
                letter4_4.SelectionStart = letter4_4.Text.Length;
                letter4_4.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter5_1_TextChanged(object sender, EventArgs e)
        {
            insertedText = letter5_1.Text;
            if (insertedText.Length == 2)
            {
                char firstChar = insertedText[0];
                char secondChar = insertedText[1];
                letter5_1.Text = firstChar.ToString();
                letter5_2.Text = secondChar.ToString();
                letter5_2.Focus();
                letter5_2.SelectionStart = letter5_2.Text.Length;
                letter5_2.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter5_2_TextChanged(object sender, EventArgs e)
        {
            insertedText = letter5_2.Text;
            if (insertedText.Length == 2)
            {
                char firstChar = insertedText[0];
                char secondChar = insertedText[1];
                letter5_2.Text = firstChar.ToString();
                letter5_3.Text = secondChar.ToString();
                letter5_3.Focus();
                letter5_3.SelectionStart = letter5_3.Text.Length;
                letter5_3.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
            else if (letter5_2.Text.Length == 0)
            {
                letter5_1.Focus();
                letter5_1.SelectionStart = letter5_1.Text.Length;
                letter5_1.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter5_3_TextChanged(object sender, EventArgs e)
        {
            insertedText = letter5_3.Text;
            if (insertedText.Length == 2)
            {
                char firstChar = insertedText[0];
                char secondChar = insertedText[1];
                letter5_3.Text = firstChar.ToString();
                letter5_4.Text = secondChar.ToString();
                letter5_4.Focus();
                letter5_4.SelectionStart = letter5_4.Text.Length;
                letter5_4.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
            else if (letter5_3.Text.Length == 0)
            {
                letter5_2.Focus();
                letter5_2.SelectionStart = letter5_2.Text.Length;
                letter5_2.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter5_4_TextChanged(object sender, EventArgs e)
        {
            insertedText = letter5_4.Text;
            if (insertedText.Length == 2)
            {
                char firstChar = insertedText[0];
                char secondChar = insertedText[1];
                letter5_4.Text = firstChar.ToString();
                letter5_5.Text = secondChar.ToString();
                letter5_5.Focus();
                letter5_5.SelectionStart = letter5_5.Text.Length;
                letter5_5.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
            else if (letter5_4.Text.Length == 0)
            {
                letter5_3.Focus();
                letter5_3.SelectionStart = letter5_3.Text.Length;
                letter5_3.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter5_5_TextChanged(object sender, EventArgs e)
        {
            if (letter5_5.Text.Length == 0)
            {
                letter5_4.Focus();
                letter5_4.SelectionStart = letter5_4.Text.Length;
                letter5_4.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter6_1_TextChanged(object sender, EventArgs e)
        {
            insertedText = letter6_1.Text;
            if (insertedText.Length == 2)
            {
                char firstChar = insertedText[0];
                char secondChar = insertedText[1];
                letter6_1.Text = firstChar.ToString();
                letter6_2.Text = secondChar.ToString();
                letter6_2.Focus();
                letter6_2.SelectionStart = letter6_2.Text.Length;
                letter6_2.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter6_2_TextChanged(object sender, EventArgs e)
        {
            insertedText = letter6_2.Text;
            if (insertedText.Length == 2)
            {
                char firstChar = insertedText[0];
                char secondChar = insertedText[1];
                letter6_2.Text = firstChar.ToString();
                letter6_3.Text = secondChar.ToString();
                letter6_3.Focus();
                letter6_3.SelectionStart = letter6_3.Text.Length;
                letter6_3.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
            else if (letter6_2.Text.Length == 0)
            {
                letter6_1.Focus();
                letter6_1.SelectionStart = letter6_1.Text.Length;
                letter6_1.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter6_3_TextChanged(object sender, EventArgs e)
        {
            insertedText = letter6_3.Text;
            if (insertedText.Length == 2)
            {
                char firstChar = insertedText[0];
                char secondChar = insertedText[1];
                letter6_3.Text = firstChar.ToString();
                letter6_4.Text = secondChar.ToString();
                letter6_4.Focus();
                letter6_4.SelectionStart = letter6_4.Text.Length;
                letter6_4.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
            else if (letter6_3.Text.Length == 0)
            {
                letter6_2.Focus();
                letter6_2.SelectionStart = letter6_2.Text.Length;
                letter6_2.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter6_4_TextChanged(object sender, EventArgs e)
        {
            insertedText = letter6_4.Text;
            if (insertedText.Length == 2)
            {
                char firstChar = insertedText[0];
                char secondChar = insertedText[1];
                letter6_4.Text = firstChar.ToString();
                letter6_5.Text = secondChar.ToString();
                letter6_5.Focus();
                letter6_5.SelectionStart = letter6_5.Text.Length;
                letter6_5.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
            else if (letter6_4.Text.Length == 0)
            {
                letter6_3.Focus();
                letter6_3.SelectionStart = letter6_3.Text.Length;
                letter6_3.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void letter6_5_TextChanged(object sender, EventArgs e)
        {
            if (letter6_5.Text.Length == 0)
            {
                letter6_4.Focus();
                letter6_4.SelectionStart = letter6_4.Text.Length;
                letter6_4.SelectionLength = 0;                      // Le ultime due righe evitano evidenziazione
            }
        }

        private void enterButton_MouseEnter(object sender, EventArgs e)
        {
            enterButton.BackColor = Color.FromArgb(10, 10, 10);
        }

        private void enterButton_MouseLeave(object sender, EventArgs e)
        {
            enterButton.BackColor = Color.FromArgb(31, 31, 31);
        }

        private void deleteButton_MouseEnter(object sender, EventArgs e)
        {
            deleteButton.BackColor = Color.FromArgb(10, 10, 10);
        }

        private void deleteButton_MouseLeave(object sender, EventArgs e)
        {
            deleteButton.BackColor = Color.FromArgb(31, 31, 31);
        }

        private void letter1_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Blocca il carattere
            }
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            string word = "";
            if (firstWordPanel.Enabled == false)
            {
                if (secondWordPanel.Enabled == false)
                {
                    if (thirdWordPanel.Enabled == false)
                    {
                        if (fourthWordPanel.Enabled == false)
                        {
                            if (fifthWordPanel.Enabled == false && letter6_1.Text.Length == 1 && letter6_2.Text.Length == 1 && letter6_3.Text.Length == 1 && letter6_4.Text.Length == 1 && letter6_5.Text.Length == 1)
                            {
                                word = letter6_1.Text + letter6_2.Text + letter6_3.Text + letter6_4.Text + letter6_5.Text;
                                // funzione controllo e validazione sesta parola
                                sixthWordPanel.Enabled = false;
                                // condizione vittoria
                            }
                            else if (fifthWordPanel.Enabled == true && letter5_1.Text.Length == 1 && letter5_2.Text.Length == 1 && letter5_3.Text.Length == 1 && letter5_4.Text.Length == 1 && letter5_5.Text.Length == 1)
                            {
                                word = letter5_1.Text + letter5_2.Text + letter5_3.Text + letter5_4.Text + letter5_5.Text;
                                // funzione controllo e validazione quinta parola
                                fifthWordPanel.Enabled = false;
                                // condizione vittoria
                                sixthWordPanel.Enabled = true;
                            }
                        }
                        else if (letter4_1.Text.Length == 1 && letter4_2.Text.Length == 1 && letter4_3.Text.Length == 1 && letter4_4.Text.Length == 1 && letter4_5.Text.Length == 1)
                        {
                            word = letter4_1.Text + letter4_2.Text + letter4_3.Text + letter4_4.Text + letter4_5.Text;
                            // funzione controllo e validazione quarta parola
                            fourthWordPanel.Enabled = false;
                            // condizione vittoria
                            fifthWordPanel.Enabled = true;
                        }
                    }
                    else if (letter3_1.Text.Length == 1 && letter3_2.Text.Length == 1 && letter3_3.Text.Length == 1 && letter3_4.Text.Length == 1 && letter3_5.Text.Length == 1)
                    {
                        word = letter3_1.Text + letter3_2.Text + letter3_3.Text + letter3_4.Text + letter3_5.Text;
                        // funzione controllo e validazione terza parola
                        thirdWordPanel.Enabled = false;
                        // condizione vittoria
                        fourthWordPanel.Enabled = true;
                    }
                }
                else if (letter2_1.Text.Length == 1 && letter2_2.Text.Length == 1 && letter2_3.Text.Length == 1 && letter2_4.Text.Length == 1 && letter2_5.Text.Length == 1)
                {
                    word = letter2_1.Text + letter2_2.Text + letter2_3.Text + letter2_4.Text + letter2_5.Text;
                    // funzione controllo e validazione seconda parola
                    secondWordPanel.Enabled = false;
                    // condizione vittoria
                    thirdWordPanel.Enabled = true;
                }
            }
            else if (letter1_1.Text.Length == 1 && letter1_2.Text.Length == 1 && letter1_3.Text.Length == 1 && letter1_4.Text.Length == 1 && letter1_5.Text.Length == 1)
            {
                word = letter1_1.Text + letter1_2.Text + letter1_3.Text + letter1_4.Text + letter1_5.Text;
                // funzione controllo e validazione prima parola
                firstWordPanel.Enabled = false;
                // condizione vittoria
                secondWordPanel.Enabled = true;
            }
        }
    }
}

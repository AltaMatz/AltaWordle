using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace AltaWordle
{
    public partial class Home : Form
    {

        private WordManager wordManager = new WordManager();
        private string language = "Italiano (IT)";
        private string insertedText = "";
        public string guessWord = "";

        public Home()
        {
            InitializeComponent();
            langSelect.SelectedIndex = 0;
        }

        // CLASSE WORDMANAGER
        public class WordManager
        {
            public List<string> guessWords = new List<string>();
            public string percorso = "";

            public int LoadWords(string language)
            {
                if (language == "Italiano (IT)")
                {
                    guessWords = new List<string>(File.ReadAllLines("WordList/guess_words.txt")); 
                    percorso = "WordList/valid_words.txt";
                    return 1;
                }
                else if (language == "Inglese (EN)")
                {
                    guessWords = new List<string>(File.ReadAllLines("WordList/guess_words_EN.txt"));
                    percorso = "WordList/valid_words_EN.txt";
                    return 2;
                }
                else if (language == "Francese (FR)")
                {
                    guessWords = new List<string>(File.ReadAllLines("WordList/guess_words_FR.txt"));
                    percorso = "WordList/valid_words_FR.txt";
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

        private void langSelect_SelectedIndexChanged(object sender, EventArgs e) // Controllare in qualsiasi momento il cambio di lingua e inserire nelle liste le parole dei .txt corrispondenti
        {
            if (langSelect.SelectedItem?.ToString() != null)
            {
                language = langSelect.SelectedItem?.ToString();
            }
            int ris = 1;
            if (language == "Italiano (IT)")
            {
                ris = 1;
            }
            else if (language == "Inglese (EN)")
            {
                ris = 2;
            }
            else if (language == "Francese (FR)")
            {
                ris = 3;
            }
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
                backButton.Text = "Vai alla Home";
                playAgainButton.Text = "Gioca ancora";
                rulesLabel.Text = "\"AltaWordle\" è un gioco che consiste nell'indovinare una parola da 5 lettere dopo un certo numero di tentativi:\n> MODALITÀ FACILE (6 tentativi)\n> MODALITÀ MEDIA (5 tentativi)\n> MODALITÀ DIFFICILE (4 tentativi)\n\nÈ possibile giocare sia come ospiti sia loggandosi con il proprio profilo\n\nLe statistiche presenti nella HomePage rappresentano la media tra tutte le partite giocate, mentre quelle presenti nell'area personale riguardano quelle del giocatore loggato\n\nLINGUE: Italiano, Inglese, Francese";
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
                backButton.Text = "Home Page";
                playAgainButton.Text = "Play again";
                rulesLabel.Text = "\"AltaWordle\" is a game that consists of guessing a 5-letter word after a certain number of attempts:\n> EASY MODE (6 attempts)\n> MEDIUM MODE (5 attempts)\n> HARD MODE (4 attempts)\n\nYou can play either as a guest or by logging in with your profile\n\nThe statistics on the HomePage represent the average of all games played, while those in each player's personal area concern that player's own games\n\nLANGUAGES: Italian, English, French";
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
                backButton.Text = "Page d'Accueil";
                playAgainButton.Text = "Rejouer";
                rulesLabel.Text = "\"AltaWordle\" est un jeu qui consiste à deviner un mot de 5 lettres après un certain nombre de tentatives:\n> MODE FACILE (6 tentatives)\n> MODE MOYEN (5 tentatives)\n> MODE DIFFICILE (4 tentatives)\n\nVous pouvez jouer tout de suite ou sélectionner votre profil\n\nLes statistiques présentes sur la page d'accueil représentent la moyenne de toutes les parties jouées, tandis que celles dans l'espace personnel concernent les parties du joueur\n\nLANGUES: Italien, Anglais, Français";
            }
        }

        // FUNZIONI "CLICK" PULSANTI HOME
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
                errorLabel.Location = new Point(307, 804);
                victoryPanel.Location = new Point(322, 245);
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
                errorLabel.Location = new Point(200, 804);
                victoryPanel.Location = new Point(215, 245);
            }
        }

        private void hostPlayButton_Click(object sender, EventArgs e)   // Partita come ospite
        {
            matchPanel.BringToFront();
            title.BringToFront();
            settingsPanel.BringToFront();
            settingsButton.BringToFront();
            homeButton.Visible = true;

            wordManager.LoadWords(language);
            guessWord = wordManager.GetGuessWord();
        }

        private void playerPlayButton_Click(object sender, EventArgs e) // Partita come giocatore loggato
        {
            // Schermata di Login con nome utente e password e tasto per la registrazione (con controllo di non ripetizione nome utente)
            // Mostrare le difficoltà giocabili, le statistiche del giocatore e tutte le info modificabili sul profilo
        }

        private void rulesButton_Click(object sender, EventArgs e)      // Interfaccia con regolamento AltaWordle
        {
            rulesPanel.BringToFront();
            title.BringToFront();
            settingsPanel.BringToFront();
            settingsButton.BringToFront();
            homeButton.Visible = true;
        }

        private void statsButton_Click(object sender, EventArgs e)      // Interfaccia con statistiche partite totali
        {
            // Mostrare statistiche (probabile utilizzo di ProgressBar per percentuali) con vittorie, sconfitte, tentativi medi
            // Se loggato, mostrare anche le statistiche personali (con possibilità di reset)
        }

        // FUNZIONI PULSANTI MENU LATERALE
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

        private void homeButton_MouseEnter(object sender, EventArgs e)
        {
            homeButton.BackColor = Color.FromArgb(31, 31, 31);
        }

        private void homeButton_MouseLeave(object sender, EventArgs e)
        {
            homeButton.BackColor = Color.FromArgb(10, 10, 10);
        }

        // FUNZIONI TEXTBOX LETTERE
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

        private void letter1_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true; // Blocca il carattere
            }
        }

        // FUNZIONI PULSANTI "CONFERMA" E "CANCELLA"
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

        private void enterButton_Click(object sender, EventArgs e)
        {
            string word = "";
            string colors = "";
            int ris = 0;
            if (letter1_1.ReadOnly == true)
            {
                if (letter2_1.ReadOnly == true)
                {
                    if (letter3_1.ReadOnly == true)
                    {
                        if (letter4_1.ReadOnly == true)
                        {
                            if (letter5_1.ReadOnly == true && letter6_1.Text.Length == 1 && letter6_2.Text.Length == 1 && letter6_3.Text.Length == 1 && letter6_4.Text.Length == 1 && letter6_5.Text.Length == 1)
                            {
                                word = letter6_1.Text + letter6_2.Text + letter6_3.Text + letter6_4.Text + letter6_5.Text;
                                ris = Convert.ToInt32(validation(word));    // LA PAROLA ESISTE?
                                if (ris == 0)
                                    return;
                                colors = compare(word, guessWord);  // LA PAROLA COINCIDE CON QUELLA SEGRETA?
                                color6(colors);     // ASSEGNAZIONE COLORI ALLE CASELLE
                                letter6_1.ReadOnly = true; letter6_2.ReadOnly = true; letter6_3.ReadOnly = true; letter6_4.ReadOnly = true; letter6_5.ReadOnly = true;
                                victory(colors);    // CONDIZIONE VITTORIA
                            }
                            else if (letter5_1.ReadOnly == false && letter5_1.Text.Length == 1 && letter5_2.Text.Length == 1 && letter5_3.Text.Length == 1 && letter5_4.Text.Length == 1 && letter5_5.Text.Length == 1)
                            {
                                word = letter5_1.Text + letter5_2.Text + letter5_3.Text + letter5_4.Text + letter5_5.Text;
                                ris = Convert.ToInt32(validation(word));    // LA PAROLA ESISTE?
                                if (ris == 0)
                                    return;
                                colors = compare(word, guessWord);  // LA PAROLA COINCIDE CON QUELLA SEGRETA?
                                color5(colors);     // ASSEGNAZIONE COLORI ALLE CASELLE
                                letter5_1.ReadOnly = true; letter5_2.ReadOnly = true; letter5_3.ReadOnly = true; letter5_4.ReadOnly = true; letter5_5.ReadOnly = true;
                                victory(colors);    // CONDIZIONE VITTORIA
                                sixthWordPanel.Enabled = true;
                                letter6_1.Focus();
                            }
                        }
                        else if (letter4_1.Text.Length == 1 && letter4_2.Text.Length == 1 && letter4_3.Text.Length == 1 && letter4_4.Text.Length == 1 && letter4_5.Text.Length == 1)
                        {
                            word = letter4_1.Text + letter4_2.Text + letter4_3.Text + letter4_4.Text + letter4_5.Text;
                            ris = Convert.ToInt32(validation(word));    // LA PAROLA ESISTE?
                            if (ris == 0)
                                return;
                            colors = compare(word, guessWord);  // LA PAROLA COINCIDE CON QUELLA SEGRETA?
                            color4(colors);     // ASSEGNAZIONE COLORI ALLE CASELLE
                            letter4_1.ReadOnly = true; letter4_2.ReadOnly = true; letter4_3.ReadOnly = true; letter4_4.ReadOnly = true; letter4_5.ReadOnly = true;
                            victory(colors);    // CONDIZIONE VITTORIA
                            fifthWordPanel.Enabled = true;
                            letter5_1.Focus();
                        }
                    }
                    else if (letter3_1.Text.Length == 1 && letter3_2.Text.Length == 1 && letter3_3.Text.Length == 1 && letter3_4.Text.Length == 1 && letter3_5.Text.Length == 1)
                    {
                        word = letter3_1.Text + letter3_2.Text + letter3_3.Text + letter3_4.Text + letter3_5.Text;
                        ris = Convert.ToInt32(validation(word));    // LA PAROLA ESISTE?
                        if (ris == 0)
                            return;
                        colors = compare(word, guessWord);  // LA PAROLA COINCIDE CON QUELLA SEGRETA?
                        color3(colors);     // ASSEGNAZIONE COLORI ALLE CASELLE
                        letter3_1.ReadOnly = true; letter3_2.ReadOnly = true; letter3_3.ReadOnly = true; letter3_4.ReadOnly = true; letter3_5.ReadOnly = true;
                        victory(colors);    // CONDIZIONE VITTORIA
                        fourthWordPanel.Enabled = true;
                        letter4_1.Focus();
                    }
                }
                else if (letter2_1.Text.Length == 1 && letter2_2.Text.Length == 1 && letter2_3.Text.Length == 1 && letter2_4.Text.Length == 1 && letter2_5.Text.Length == 1)
                {
                    word = letter2_1.Text + letter2_2.Text + letter2_3.Text + letter2_4.Text + letter2_5.Text;
                    ris = Convert.ToInt32(validation(word));    // LA PAROLA ESISTE?
                    if (ris == 0)
                        return;
                    colors = compare(word, guessWord);  // LA PAROLA COINCIDE CON QUELLA SEGRETA?
                    color2(colors);     // ASSEGNAZIONE COLORI ALLE CASELLE
                    letter2_1.ReadOnly = true; letter2_2.ReadOnly = true; letter2_3.ReadOnly = true; letter2_4.ReadOnly = true; letter2_5.ReadOnly = true;
                    victory(colors);    // CONDIZIONE VITTORIA
                    thirdWordPanel.Enabled = true;
                    letter3_1.Focus();
                }
            }
            else if (letter1_1.Text.Length == 1 && letter1_2.Text.Length == 1 && letter1_3.Text.Length == 1 && letter1_4.Text.Length == 1 && letter1_5.Text.Length == 1)
            {
                word = letter1_1.Text + letter1_2.Text + letter1_3.Text + letter1_4.Text + letter1_5.Text;
                ris = Convert.ToInt32(validation(word));    // LA PAROLA ESISTE?
                if (ris == 0)
                    return;
                colors = compare(word, guessWord);      // LA PAROLA COINCIDE CON QUELLA SEGRETA?
                color1(colors);     // ASSEGNAZIONE COLORI ALLE CASELLE
                letter1_1.ReadOnly = true; letter1_2.ReadOnly = true; letter1_3.ReadOnly = true; letter1_4.ReadOnly = true; letter1_5.ReadOnly = true;
                victory(colors);    // CONDIZIONE VITTORIA
                secondWordPanel.Enabled = true;
                letter2_1.Focus();
            }
            else
            {
                errorLabel.Text = "ERRORE: La parola deve essere lunga 5 lettere!";
                errorLabel.Visible = true;
            }
            // DEBUG LABEL PAROLA E COLORE
            //debugWordLabel.Visible = true;
            //debugWordLabel.Text = word;
            //debugColorLabel.Visible = true;
            //debugColorLabel.Text = colors;
        }

        // FUNZIONI DI GIOCO
        private bool validation(string word)
        {
            errorLabel.Visible = false;
            foreach (string validWord in File.ReadLines("WordList/valid_words.txt"))
            {
                if (word == validWord)
                {
                    return true;
                }
            }
            errorLabel.Visible = true;
            errorLabel.Text = "ERRORE: La parola '" + word + "' non è valida!";
            return false;
        }

        private string compare(string word, string guessWord)
        {

            char[] colors = new char[5];
            bool[] used = new bool[5];  // verdi e gialle sono "true" nelle rispettive posizioni

            for (int i = 0; i < 5; i++)
            {
                if (word[i] == guessWord[i])
                {
                    colors[i] = 'G';    // GREEN
                    used[i] = true;
                }
            }

            for (int i = 0; i < 5; i++)
            {
                if (colors[i] == 'G') continue; // "continue" fa i+1 e ricomincia da capo il ciclo se la lettera è verde

                colors[i] = 'B';    // BLACK
                for (int j = 0; j < 5; j++)
                {
                    if (!used[j] && word[i] == guessWord[j])    // la lettera diventa gialla solo se ci sono lettere non verdi ma contenute nella parola corretta
                    {
                        colors[i] = 'Y';    //YELLOW
                        used[j] = true;
                        break;
                    }
                }
            }

            return new string(colors);
        }

        private void victory(string colors)
        {
            if (colors == "GGGGG")
            {
                Task.Delay(1200);
                victoryPanel.Visible = true;
                resultLabel.Visible = true;
                if (language == "Italiano (IT)")
                {
                    resultLabel.Text = "VITTORIA!";
                }
                else if (language == "Inglese (EN)")
                {
                    resultLabel.Text = "VICTORY!";
                }
                else
                {
                    resultLabel.Text = "VICTOIRE!";
                }
                resultLabel.ForeColor = Color.FromArgb(0, 255, 0);
                enterButton.Enabled = false;
                deleteButton.Enabled = false;
            }
            else if (letter6_1.Text.Length == 1 && letter6_2.Text.Length == 1 && letter6_3.Text.Length == 1 && letter6_4.Text.Length == 1 && letter6_5.Text.Length == 1)
            {
                Task.Delay(1200);
                victoryPanel.Visible = true;
                resultLabel.Visible = true;
                if (language == "Italiano (IT)")
                {
                    resultLabel.Text = "SCONFITTA!";
                }
                else if (language == "Inglese (EN)")
                {
                    resultLabel.Text = "DEFEAT!";
                }
                else
                {
                    resultLabel.Text = "DEFAITE!";
                }
                resultLabel.ForeColor = Color.FromArgb(192, 0, 192);
                enterButton.Enabled = false;
                deleteButton.Enabled = false;
            }
        }

        private async Task color1(string colors)
        {
            for (int i = 0; i < 5; i++)
            {
                if (colors[i] == 'G')
                {
                    switch (i)
                    {
                        case 0:
                            letter1_1.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 1:
                            letter1_2.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 2:
                            letter1_3.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 3:
                            letter1_4.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 4:
                            letter1_5.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                    }
                }
                else if (colors[i] == 'Y')
                {
                    switch (i)
                    {
                        case 0:
                            letter1_1.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                        case 1:
                            letter1_2.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                        case 2:
                            letter1_3.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                        case 3:
                            letter1_4.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                        case 4:
                            letter1_5.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                    }
                }
                else if (colors[i] == 'B')
                {
                    switch (i)
                    {
                        case 0:
                            letter1_1.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                        case 1:
                            letter1_2.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                        case 2:
                            letter1_3.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                        case 3:
                            letter1_4.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                        case 4:
                            letter1_5.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                    }
                }
                else
                {
                    switch (i)
                    {
                        case 0:
                            letter1_1.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                        case 1:
                            letter1_2.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                        case 2:
                            letter1_3.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                        case 3:
                            letter1_4.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                        case 4:
                            letter1_5.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                    }
                }
                await Task.Delay(200);
            }
        }

        private async Task color2(string colors)
        {
            for (int i = 0; i < 5; i++)
            {
                if (colors[i] == 'G')
                {
                    switch (i)
                    {
                        case 0:
                            letter2_1.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 1:
                            letter2_2.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 2:
                            letter2_3.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 3:
                            letter2_4.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 4:
                            letter2_5.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                    }
                }
                else if (colors[i] == 'Y')
                {
                    switch (i)
                    {
                        case 0:
                            letter2_1.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                        case 1:
                            letter2_2.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                        case 2:
                            letter2_3.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                        case 3:
                            letter2_4.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                        case 4:
                            letter2_5.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                    }
                }
                else if (colors[i] == 'B')
                {
                    switch (i)
                    {
                        case 0:
                            letter2_1.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                        case 1:
                            letter2_2.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                        case 2:
                            letter2_3.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                        case 3:
                            letter2_4.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                        case 4:
                            letter2_5.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                    }
                }
                else
                {
                    switch (i)
                    {
                        case 0:
                            letter2_1.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                        case 1:
                            letter2_2.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                        case 2:
                            letter2_3.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                        case 3:
                            letter2_4.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                        case 4:
                            letter2_5.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                    }
                }
                await Task.Delay(200);
            }
        }

        private async Task color3(string colors)
        {
            for (int i = 0; i < 5; i++)
            {
                if (colors[i] == 'G')
                {
                    switch (i)
                    {
                        case 0:
                            letter3_1.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 1:
                            letter3_2.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 2:
                            letter3_3.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 3:
                            letter3_4.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 4:
                            letter3_5.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                    }
                }
                else if (colors[i] == 'Y')
                {
                    switch (i)
                    {
                        case 0:
                            letter3_1.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                        case 1:
                            letter3_2.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                        case 2:
                            letter3_3.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                        case 3:
                            letter3_4.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                        case 4:
                            letter3_5.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                    }
                }
                else if (colors[i] == 'B')
                {
                    switch (i)
                    {
                        case 0:
                            letter3_1.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                        case 1:
                            letter3_2.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                        case 2:
                            letter3_3.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                        case 3:
                            letter3_4.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                        case 4:
                            letter3_5.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                    }
                }
                else
                {
                    switch (i)
                    {
                        case 0:
                            letter3_1.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                        case 1:
                            letter3_2.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                        case 2:
                            letter3_3.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                        case 3:
                            letter3_4.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                        case 4:
                            letter3_5.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                    }
                }
                await Task.Delay(200);
            }
        }

        private async Task color4(string colors)
        {
            for (int i = 0; i < 5; i++)
            {
                if (colors[i] == 'G')
                {
                    switch (i)
                    {
                        case 0:
                            letter4_1.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 1:
                            letter4_2.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 2:
                            letter4_3.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 3:
                            letter4_4.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 4:
                            letter4_5.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                    }
                }
                else if (colors[i] == 'Y')
                {
                    switch (i)
                    {
                        case 0:
                            letter4_1.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                        case 1:
                            letter4_2.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                        case 2:
                            letter4_3.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                        case 3:
                            letter4_4.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                        case 4:
                            letter4_5.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                    }
                }
                else if (colors[i] == 'B')
                {
                    switch (i)
                    {
                        case 0:
                            letter4_1.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                        case 1:
                            letter4_2.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                        case 2:
                            letter4_3.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                        case 3:
                            letter4_4.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                        case 4:
                            letter4_5.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                    }
                }
                else
                {
                    switch (i)
                    {
                        case 0:
                            letter4_1.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                        case 1:
                            letter4_2.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                        case 2:
                            letter4_3.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                        case 3:
                            letter4_4.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                        case 4:
                            letter4_5.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                    }
                }
                await Task.Delay(200);
            }
        }

        private async Task color5(string colors)
        {
            for (int i = 0; i < 5; i++)
            {
                if (colors[i] == 'G')
                {
                    switch (i)
                    {
                        case 0:
                            letter5_1.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 1:
                            letter5_2.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 2:
                            letter5_3.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 3:
                            letter5_4.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 4:
                            letter5_5.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                    }
                }
                else if (colors[i] == 'Y')
                {
                    switch (i)
                    {
                        case 0:
                            letter5_1.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                        case 1:
                            letter5_2.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                        case 2:
                            letter5_3.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                        case 3:
                            letter5_4.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                        case 4:
                            letter5_5.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                    }
                }
                else if (colors[i] == 'B')
                {
                    switch (i)
                    {
                        case 0:
                            letter5_1.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                        case 1:
                            letter5_2.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                        case 2:
                            letter5_3.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                        case 3:
                            letter5_4.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                        case 4:
                            letter5_5.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                    }
                }
                else
                {
                    switch (i)
                    {
                        case 0:
                            letter5_1.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                        case 1:
                            letter5_2.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                        case 2:
                            letter5_3.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                        case 3:
                            letter5_4.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                        case 4:
                            letter5_5.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                    }
                }
                await Task.Delay(200);
            }
        }

        private async Task color6(string colors)
        {
            for (int i = 0; i < 5; i++)
            {
                if (colors[i] == 'G')
                {
                    switch (i)
                    {
                        case 0:
                            letter6_1.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 1:
                            letter6_2.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 2:
                            letter6_3.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 3:
                            letter6_4.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                        case 4:
                            letter6_5.BackColor = Color.FromArgb(0, 255, 0);
                            break;
                    }
                }
                else if (colors[i] == 'Y')
                {
                    switch (i)
                    {
                        case 0:
                            letter6_1.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                        case 1:
                            letter6_2.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                        case 2:
                            letter6_3.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                        case 3:
                            letter6_4.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                        case 4:
                            letter6_5.BackColor = Color.FromArgb(192, 0, 192);
                            break;
                    }
                }
                else if (colors[i] == 'B')
                {
                    switch (i)
                    {
                        case 0:
                            letter6_1.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                        case 1:
                            letter6_2.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                        case 2:
                            letter6_3.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                        case 3:
                            letter6_4.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                        case 4:
                            letter6_5.BackColor = Color.FromArgb(0, 0, 0);
                            break;
                    }
                }
                else
                {
                    switch (i)
                    {
                        case 0:
                            letter6_1.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                        case 1:
                            letter6_2.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                        case 2:
                            letter6_3.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                        case 3:
                            letter6_4.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                        case 4:
                            letter6_5.BackColor = Color.FromArgb(31, 31, 31);
                            break;
                    }
                }
                await Task.Delay(200);
            }
        }

        private void refresh()
        {
            letter1_1.Text = ""; letter1_2.Text = ""; letter1_3.Text = ""; letter1_4.Text = ""; letter1_5.Text = "";
            letter2_1.Text = ""; letter2_2.Text = ""; letter2_3.Text = ""; letter2_4.Text = ""; letter2_5.Text = "";
            letter3_1.Text = ""; letter3_2.Text = ""; letter3_3.Text = ""; letter3_4.Text = ""; letter3_5.Text = "";
            letter4_1.Text = ""; letter4_2.Text = ""; letter4_3.Text = ""; letter4_4.Text = ""; letter4_5.Text = "";
            letter5_1.Text = ""; letter5_2.Text = ""; letter5_3.Text = ""; letter5_4.Text = ""; letter5_5.Text = "";
            letter6_1.Text = ""; letter6_2.Text = ""; letter6_3.Text = ""; letter6_4.Text = ""; letter6_5.Text = "";

            color1("XXXXX");
            color2("XXXXX");
            color3("XXXXX");
            color4("XXXXX");
            color5("XXXXX");
            color6("XXXXX");

            sixthWordPanel.Enabled = false; letter6_1.ReadOnly = false; letter6_2.ReadOnly = false; letter6_3.ReadOnly = false; letter6_4.ReadOnly = false; letter6_5.ReadOnly = false;
            fifthWordPanel.Enabled = false; letter5_1.ReadOnly = false; letter5_2.ReadOnly = false; letter5_3.ReadOnly = false; letter5_4.ReadOnly = false; letter5_5.ReadOnly = false;
            fourthWordPanel.Enabled = false; letter4_1.ReadOnly = false; letter4_2.ReadOnly = false; letter4_3.ReadOnly = false; letter4_4.ReadOnly = false; letter4_5.ReadOnly = false;
            thirdWordPanel.Enabled = false; letter3_1.ReadOnly = false; letter3_2.ReadOnly = false; letter3_3.ReadOnly = false; letter3_4.ReadOnly = false; letter3_5.ReadOnly = false;
            secondWordPanel.Enabled = false; letter2_1.ReadOnly = false; letter2_2.ReadOnly = false; letter2_3.ReadOnly = false; letter2_4.ReadOnly = false; letter2_5.ReadOnly = false;
            firstWordPanel.Enabled = true; letter1_1.ReadOnly = false; letter1_2.ReadOnly = false; letter1_3.ReadOnly = false; letter1_4.ReadOnly = false; letter1_5.ReadOnly = false;

            errorLabel.Visible = false;
            enterButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        // FUNZIONI "CLICK" PULSANTI VITTORIA E SCONFITTA
        private void backButton_Click(object sender, EventArgs e)
        {
            refresh();
            victoryPanel.Visible = false;
            homePanel.BringToFront();
            title.BringToFront();
            settingsPanel.BringToFront();
            settingsButton.BringToFront();
            homeButton.Visible = false;
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            refresh();
            victoryPanel.Visible = false;
            wordManager.LoadWords(language);
            guessWord = wordManager.GetGuessWord();
        }
    }
}

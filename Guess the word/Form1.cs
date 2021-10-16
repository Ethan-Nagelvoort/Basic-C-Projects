using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    public partial class Form1 : Form
    {
        WordList wordList;
        Word myWord;
        Label[] labelArray;
        int gCount = 0;
        string word, word1;
        

        private string newgame()
        {
            wordList = new WordList();
            if (wordList.failed)
            {
                MessageBox.Show("There was a problem reading the word file");
                return null;
            }
            else
            {
                myWord = new Word();
                word = wordList.GetRandomWord();
                word1 = myWord.convertWord(word);
                destroyLabels();
                labelArray = new Label[word1.Length];
                CreateLabels();
                return word1;
            }
        }

        private void Guessb_Click(object sender, EventArgs e)
        {
            
            char[] wordArray;
            wordArray = word1.ToCharArray();
            if((textBox1.Text).Length > 1)//cannot enter multiple words
            {
                MessageBox.Show("Please only put one lower case letter in the text box\nPlease have the letter at the beinning of the textbox");
                textBox1.Clear();
                textBox1.Focus();
                return;
            }
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("Please do not enter anything blank");//blanks are invalid
                textBox1.Clear();
                textBox1.Focus();
                return;
            }
            char guessletter = Convert.ToChar(textBox1.Text[0]);
            if(Char.IsUpper(guessletter) == true)//only put lowercase words
            {
                MessageBox.Show("Please only put one lower case letter in the text box\nPlease have the letter at the beinning of the textbox");
                textBox1.Clear();
                textBox1.Focus();
                return;
            }
            guessletter = char.ToUpper(guessletter);
            for(int i =0; i<wordArray.Length; i++)
            {
                if(guessletter == wordArray[i])
                {
                    textBox2.Text = guessletter.ToString();
                    labelArray[i].Text = guessletter.ToString();
                    gCount++;
                }
                textBox1.Clear();
                textBox1.Focus();
            }
            if(gCount == wordArray.LongCount())
            {
                MessageBox.Show("You guessed it correctly!!!!");//show that you are correct
                gCount = 0;
            }
        }

        public Form1()
        {
            InitializeComponent();
            newgame();//start wtih a new game
        }

        private void CreateLabels()
        {
            for(int i =0; i < labelArray.Count(); i++) // settings for label of each word in the chosen random word
            {
                labelArray[i] = new Label();
                labelArray[i].Name = "lblLetter" + i;
                labelArray[i].BorderStyle = BorderStyle.Fixed3D;
                labelArray[i].Size = new Size(60, 60);
                labelArray[i].Location = new Point((i + 1) * 56, 50);
                labelArray[i].Text = "";
                labelArray[i].TextAlign = ContentAlignment.MiddleCenter;
                labelArray[i].Font = new Font("Arial Black", 24, FontStyle.Bold);
                this.Controls.Add(labelArray[i]);
            }
        }

        private void newGameb_Click(object sender, EventArgs e)
        {
            newgame();//start new game
        }

        private void exitb_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for playing!!!");
            this.Close();
        }

       

        private void destroyLabels()
        {
            if (labelArray == null)
                return;
            for (int i=0; i < labelArray.Length; i++)
            {
                if (labelArray[i] != null)
                    this.Controls.Remove(labelArray[i]);
                labelArray[i] = null;
            }
        }
       
    }
}

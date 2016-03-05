using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_ReserseSentence
{
    public partial class ReverseSentence : Form
    {
        public ReverseSentence()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            string input = txbInput.Text;

            // Split the words and reverse their order
            char[] punctuationMarks = new char[] { ' ', ',', '.', ';', ':', '!', '?', '(', ')' };
            string[] words = input.Split(punctuationMarks, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);

            // Create a punctuation marks mask
            List<char> marksPosition = new List<char>();

            foreach (char character in input)
            {
                switch (character)
                {
                    case ' ': marksPosition.Add(character); break;
                    case ',': marksPosition.Add(character); break;
                    case '.': marksPosition.Add(character); break;
                    case ':': marksPosition.Add(character); break;
                    case ';': marksPosition.Add(character); break;
                    case '!': marksPosition.Add(character); break;
                    case '?': marksPosition.Add(character); break;
                    case '(': marksPosition.Add(character); break;
                    case ')': marksPosition.Add(character); break;

                    default: marksPosition.Add('n'); break;
                }
            }
        }

    }
}

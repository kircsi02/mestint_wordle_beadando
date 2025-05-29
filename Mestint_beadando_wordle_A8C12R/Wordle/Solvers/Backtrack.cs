using Wordle.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Wordle.Solvers
{
    public class Backtrack : Solver
    {
        private State currentState;
        private WordList wordList;
        private Form2 form2;
        private char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        private HashSet<string> visitedWords;
        int maxAttempts = 0;

        public Backtrack(Form2 form, int maxattempts)
        {
            currentState = new State();
            wordList = new WordList("5letterenglishwords.txt");
            form2 = form;
            maxAttempts = maxattempts;
            visitedWords = new HashSet<string>();
        }

        public override void Solve()
        {
            form2.textBox1.Text = currentState.StartingWord;
            form2.endresultTxtbox.Text = currentState.TargetgWord;

            BacktrackRecursive(currentState.Word, 0);
        }

        private void BacktrackRecursive(string word, int attempts)
        {
            if (attempts >= maxAttempts)
            {
                form2.ChangeResultLblText("Max attempts reached. Goal state not found.");
                

                return;
            }
            if (word.Equals(currentState.TargetgWord, StringComparison.OrdinalIgnoreCase))
            {
                form2.ChangeResultLblText("Goal state reached!");
                return;
            }
            if (visitedWords.Contains(word))
            {
                return;
            }
            visitedWords.Add(word);

            Console.WriteLine("Latest visited word: " + visitedWords.Last());

            form2.ChangeRtText(word);

            for (int i = 0; i < word.Length; i++)
            {
                char[] wordChars = word.ToCharArray();
                foreach (char letter in letters)
                {
                    wordChars[i] = letter;
                    string newWord = new string(wordChars);

                    if (wordList.wordList.Contains(newWord))
                    {
                        form2.ChangeRtText(newWord);
                        Console.WriteLine("Attempts: " + attempts);
                        BacktrackRecursive(newWord, attempts + 1);
                    }
                }
            }

        }

        public void Reset()
        {
            currentState.Word = currentState.StartingWord;
            visitedWords.Clear();
        }
    }
}
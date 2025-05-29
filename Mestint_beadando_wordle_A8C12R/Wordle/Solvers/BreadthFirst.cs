using Wordle.Interfaces;
using System;
using System.Collections.Generic;

namespace Wordle.Solvers
{
    public class BreadthFirst : Solver
    {
        private State currentState;
        private WordList wordList;
        private Form2 form2;
        private char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        private HashSet<string> visitedWords;
        private int stepCount;

        public BreadthFirst(Form2 form)
        {
            currentState = new State();
            wordList = new WordList("5letterenglishwords.txt");
            form2 = form;
            visitedWords = new HashSet<string>();
            stepCount = 0;
        }

        public override void Solve()
        {
            form2.textBox1.Text = currentState.Word;
            form2.endresultTxtbox.Text = currentState.TargetgWord;

            BreadthFirstSearch(currentState.Word);
        }

        private void BreadthFirstSearch(string startWord)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue(startWord);

            while (queue.Count > 0)
            {
                string word = queue.Dequeue();

                if (visitedWords.Contains(word))
                {
                    continue;
                }

                stepCount++;
                Console.WriteLine("Stepcount: " + stepCount);
                form2.ChangeRtText(word);

                visitedWords.Add(word);

                if (word.Equals(currentState.TargetgWord, StringComparison.OrdinalIgnoreCase))
                {
                    form2.ChangeResultLblText($"Goal state reached in {stepCount} steps!");
                    return;
                }

                for (int i = 0; i < word.Length; i++)
                {
                    char[] wordChars = word.ToCharArray();
                    foreach (char letter in letters)
                    {
                        wordChars[i] = letter;
                        string newWord = new string(wordChars);

                        if (wordList.wordList.Contains(newWord) && !visitedWords.Contains(newWord))
                        {
                            queue.Enqueue(newWord);
                        }
                    }
                }
            }

            form2.ChangeResultLblText("No solution found.");
        }

        public void Reset()
        {
            currentState.Word = currentState.StartingWord;
            visitedWords.Clear();
            stepCount = 0;
        }
    }
}
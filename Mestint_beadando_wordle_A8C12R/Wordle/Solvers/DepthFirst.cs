using Wordle.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Wordle.Solvers
{
    public class DepthFirst : Solver
    {
        private State currentState;
        private WordList wordList;
        private Form2 form2;
        private char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        private HashSet<string> visitedWords; // Loopcheck tároló

        public DepthFirst(Form2 form)
        {
            currentState = new State();
            wordList = new WordList("5letterenglishwords.txt");
            form2 = form;
            visitedWords = new HashSet<string>();
        }

        public override void Solve()
        {
            form2.textBox1.Text = currentState.StartingWord;
            form2.endresultTxtbox.Text = currentState.TargetgWord;

            DepthFirstSearch(currentState.Word);
        }

        private void DepthFirstSearch(string startWord)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push(startWord);

            while (stack.Count > 0)
            {
                string word = stack.Pop();

                if (visitedWords.Contains(word))
                {
                    continue;
                }

                Console.WriteLine("Current word: " + word);
                form2.ChangeRtText(word);

                visitedWords.Add(word);
                Console.WriteLine("Visited words latest: " + visitedWords.Last());

                if (word.Equals(currentState.TargetgWord, StringComparison.OrdinalIgnoreCase))
                {
                    form2.ChangeResultLblText("Goal state reached!");
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
                            form2.ChangeRtText(newWord);
                            stack.Push(newWord);
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
        }
    }
}
using Wordle.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wordle.Solvers
{
    public class TrialandError : Solver
    {
        State currentState = new State();
        Form2 form2;
        WordList wordList = new WordList("5letterenglishwords.txt");
        public Random rnd = new Random();

        char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        public TrialandError(Form2 form)
        {
            form2 = form;
        }

        public override void Solve()
        {
            form2.textBox1.Text = currentState.StartingWord;
            form2.endresultTxtbox.Text = currentState.TargetgWord;

            char randomLetter = letters[rnd.Next(letters.Length)];
            Console.WriteLine("Chosen letter: " + randomLetter);
            for (int i = 0; i < currentState.Word.Length; i++)
            {
                char[] wordChars = currentState.Word.ToCharArray();
                if (wordChars[i] != randomLetter)
                {
                    wordChars[i] = randomLetter;
                    currentState.Word = new string(wordChars);
                    Console.WriteLine("Created word: " + currentState.Word);
                }
                for (int j = 0; j < wordList.wordList.Count; j++)
                {
                    if (wordList.wordList.Contains(currentState.Word))
                    {
                        currentState.IsValid();
                        form2.ChangeRtText(currentState.Word);
                    }
                }
                randomLetter = letters[rnd.Next(letters.Length)];
            }
            if (currentState.IsGoalState())
            {
                form2.ChangeResultLblText("Goal state reached!");
            }
            else
            {
                form2.ChangeResultLblText("Goal state not reached...");
            }
        }

        public void Reset()
        {
            currentState.Word = currentState.StartingWord;
        }
    }
}

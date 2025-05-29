using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wordle.Interfaces;

namespace Wordle
{
    public class State : ICloneable
    {
        public string Word { get; set; }
        private const string targetWord = "tiger";
        private const string startingWord = "mouse";
        WordList wordList = new WordList("5letterenglishwords.txt");
        public string StartingWord { get => startingWord; }
        public string TargetgWord { get => targetWord; }

        Form2 form2 = new Form2();
        List<string> broadcast = new List<string>();

        public State()
        {
            Word = startingWord;
        }

        public object Clone()
        {
            return new State();
        }

        public bool IsGoalState()
        {
            return Word.Equals(targetWord, StringComparison.OrdinalIgnoreCase);
        }
        public bool IsValid()
        {
            if (wordList.wordList.Contains(Word))
            {
                return true;
            }
            else return false;
        }

        public override bool Equals(object obj)
        {
            return obj is State other && this.Word == other.Word;
        }
        public override int GetHashCode()
        {
            return Word.GetHashCode();
        }
        public override string ToString()
        {
            return Word;
        }
    }
}

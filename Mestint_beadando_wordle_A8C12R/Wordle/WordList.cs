using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WordList
{
    public ISet<string> wordList { get; } = new HashSet<string>();

    string filePath;
    int minLength = int.MaxValue;
    int maxLength = 0;

    public int getMinLength() { return minLength; }
    public int getMaxLength() { return maxLength; }

    bool isLoaded = false;

    protected bool LoadWordlist(string filePath)
    {
        if (File.Exists(filePath))
        {
            try
            {
                string[] words = File.ReadAllLines(filePath);
                foreach (var word in words)
                {
                    string formatted = word.ToLower();

                    if (!formatted.All(Char.IsLetter))
                        continue;

                    maxLength = Math.Max(maxLength, formatted.Length);
                    minLength = Math.Min(minLength, formatted.Length);

                    wordList.Add(formatted);
                }

                return isLoaded = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba: " + ex.Message);
            }
        }
        else
        {
            Console.WriteLine("A fájl nem található: " + filePath);
        }

        return isLoaded = false;
    }

    public WordList(string filePath)
    {
        LoadWordlist(filePath);
    }
}

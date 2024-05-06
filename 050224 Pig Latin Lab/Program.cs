
bool playAgain = true;

while (playAgain)
{
    Console.Write("Enter a word: ");
    

    string word = Console.ReadLine();
    string fLetter = word.Substring(0, 1);
    char[] vowels = { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U'};
    string[] symbols = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "=", "+"};

    bool noSymbols = true;
   

    // number + symbol translation
    foreach (string symbol in symbols)
    {
        if (word.Contains(symbol))
        {
            Console.WriteLine(word);
            noSymbols = false;
            break;
        }

    }
   

    if (noSymbols)
    {
        // vowel
        foreach (char vowel in vowels)
        {
            if (fLetter.Contains(vowel)) 
            {
                Console.WriteLine($"{word}way");
            }
        }


        // consonant
        if (fLetter != "a" && fLetter != "A" && fLetter != "e" && fLetter != "E" && fLetter != "i" && fLetter != "I" && fLetter != "o" && fLetter != "O" && fLetter != "u" && fLetter != "U")
        {
            for (int i = 0; i < word.Length; i++)
            {
                string firstVowel = word.Substring(i, 1);
                foreach (char vowel in vowels)
                {
                    if (firstVowel.Contains(vowel))
                    {
                        string wordBeforeVowel = word.Substring(0, i);
                        string wordAfterVowel = word.Substring(i);
                        Console.WriteLine($"{wordAfterVowel}{wordBeforeVowel}ay");
                        i = word.Length;
                    }
                }
            }
        }
    }


    while (true)
    {
        Console.WriteLine("Translate another word? y/n: ");
        string agreeTranslate = Console.ReadLine().ToLower();

        if (agreeTranslate == "y") break;
        else if (agreeTranslate == "n") 
        {
            playAgain = false; 
            break;
        } else
        {
            Console.WriteLine("Not a valid option.");
            continue;
        }
    }

}


    // take line instead of word












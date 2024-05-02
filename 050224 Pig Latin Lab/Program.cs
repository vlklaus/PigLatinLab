    //string wordMinusFirst = word.Substring(1);

Console.Write("Enter a word: ");

string word = Console.ReadLine().ToLower();
string fLetter = word.Substring(0, 1);
char[] vowels = { 'a', 'e', 'i', 'o', 'u' };


bool getOut = false;


// vowel
foreach (char vowel in vowels)
{
    if (fLetter.Contains(vowel)) //char fLetter = word[0];
    {
        Console.WriteLine($"{word}way");
    }
}


//consonant
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
            getOut = true;
        }
        if (getOut) break;

    }
    if (getOut) break;

}






















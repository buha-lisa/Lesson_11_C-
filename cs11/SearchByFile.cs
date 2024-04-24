
namespace cs11
{
    internal class SearchByFile
    {
        public void Task5()
        {
            Console.WriteLine("Enter the file path:");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error...");
                return;
            }

            string text = File.ReadAllText(filePath);
            Console.WriteLine("Enter the word to search:");
            string wordToSearch = Console.ReadLine();
            
            if (!text.Contains(wordToSearch))
            {
                Console.WriteLine("Error... Word is not in text");
                return;
            }

            int count = 0;
            int index = 0;
            while ((index = text.IndexOf(wordToSearch, index)) != -1)
            {
                count++;
                Console.WriteLine($"Found '{wordToSearch}' at index {index}");
                index += wordToSearch.Length;
            }
            Console.WriteLine($"Number of occurrences: {count}");

            char[] charArray = wordToSearch.ToCharArray();
            Array.Reverse(charArray);
            string reverseWord = new string(charArray);
            count = 0;
            index = 0;
            while ((index = text.IndexOf(reverseWord, index)) != -1)
            {
                count++;
                index += reverseWord.Length;
            }
            Console.WriteLine($"Number of occurrences: {count}");
        }
        public void Task6()
        {
            Console.WriteLine("Enter the file path:");
            string filePath = Console.ReadLine();

            if (!File.Exists(filePath))
            {
                Console.WriteLine("Error...");
                return;
            }

            int numOfSentence = 0;
            int numOfUpper = 0; 
            int numOfLower = 0;
            int numOfVowels = 0;
            int numOfConsonants = 0;
            int numOfNumber = 0;
           
            string text = File.ReadAllText(filePath);
            foreach (char c in text)
            {
                if (c == '.' || c == '!' || c == '?')
                    numOfSentence++;
                else if (char.IsUpper(c))
                    numOfUpper++;
                else if (char.IsLower(c))
                    numOfLower++;
                else if ("AEIOUaeiou".Contains(c))
                    numOfVowels++;
                else if (char.IsLetter(c))
                    numOfConsonants++;
                else if (char.IsDigit(c))
                    numOfNumber++;
            }

            Console.WriteLine("File statistic:");
            Console.WriteLine($"Number of sentences: {numOfSentence}");
            Console.WriteLine($"Number of capital letters: {numOfUpper}");
            Console.WriteLine($"Number of small letters: {numOfLower}");
            Console.WriteLine($"Number of vowels: {numOfVowels}");
            Console.WriteLine($"Number of consonant letters: {numOfConsonants}");
            Console.WriteLine($"Number of digits: {numOfNumber}");
        }
    }
}

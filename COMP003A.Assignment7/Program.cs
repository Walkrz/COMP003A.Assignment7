namespace COMP003A.Assignment7
{
    class Program
    {
        /* Author: Zachary Walker
        * Course: COMP-003A-L01
        * Purpose: Code for Assignment 7
        */

        static void Main()
        {
            // Array - CharacterCounter Section
            SectionSeparator();
            Console.WriteLine("      Array - CharacterCounter Section");
            SectionSeparator();
            Console.Write("Please enter a letter \n");
            char letterInput = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.Write("Please enter a word \n");
            string wordInput = Console.ReadLine();

            int count = CharacterCounter(letterInput, wordInput);
            Console.WriteLine($"There are {count} letter {letterInput} in the word {wordInput}");
            SectionSeparator();

            // Array - IsPalindrome Section
            Console.WriteLine("      Array - IsPalindrome Section");
            SectionSeparator();
            Console.Write("\n");

            Console.Write("Please enter a word to check if it is a palandrome \n");
            string palindromeInput = Console.ReadLine();

            bool isPalindrome = IsPalindrome(palindromeInput);

            Console.WriteLine($"Is the word {palindromeInput} a palindrome: {isPalindrome}");
            SectionSeparator();

            // List - Add Section
            Console.WriteLine("      List - Add Section");
            SectionSeparator();
            List<string> names = new List<string>();
            char userInput = default;

            do
            {
                Console.Write("\nPlease enter a name \n");
                string name = Console.ReadLine();
                names.Add(name);

                Console.Write("Press any key to add more or (e) to exit: \n");
                userInput = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (userInput != 'e');

            Console.Write("\n");
            SectionSeparator();

            // List - Traversal Section
            Console.WriteLine("     List - Traversal Section");
            SectionSeparator();
            TraverseList(names);
            SectionSeparator();

            // List - Reverse Traversal Section
            Console.WriteLine("     List - Reverse Traversal Section");
            SectionSeparator();
            TraverseListReverse(names);
        }

        // Section Separator Method
        static void SectionSeparator()
        {
            Console.WriteLine(new string('*', 50));
        }

        // CharacterCounter Method
        static int CharacterCounter(char characterInput, string word)
        {
            int count = 0;
            characterInput = char.ToLower(characterInput);
            word = word.ToLower();

            foreach (char c in word)
            {
                if (c == characterInput)
                {
                    count++;
                }
            }

            return count;
        }

        // IsPalindrome Method
        static bool IsPalindrome(string word)
        {
            string reversedWord = "";

            word = word.ToLower();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }

            return word == reversedWord;
        }

        // TraverseList Method
        static void TraverseList(List<string> list)
        {
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
        }

        // TraverseListReverse Method
        static void TraverseListReverse(List<string> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}

namespace MethodForFindWordIntoTheCentence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "I'am earth Imperator";
            string word = "imperator";
            bool isTrue = CustomCharAt(text, word);
            if (isTrue) 
            {
                Console.WriteLine("Its in!!!");
            }
            else
            {
                Console.WriteLine("Can't Find");
            }
        }

        public static bool CustomCharAt(string text, string word)
        {
            text = text.ToLower();
            word = word.ToLower();

            for (int i = 0; i <= text.Length - word.Length; i++)
            {
                int j = 0;
                for (j = 0; j < word.Length; j++)
                {
                    if (text[i + j] != word[j])
                    {
                        break;
                    }
                }
                if (j == word.Length)
                { 
                    return true; 
                }
            }
            return false;
        }
    }
}


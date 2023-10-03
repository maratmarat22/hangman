namespace виселица
{
    internal class Program
    {


        static void Main(string[] args)
        {
            string word = "виселица";


            char[] hiddenword = new char[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                hiddenword[i] = '_';
            }

            Console.WriteLine("{0}", string.Join(" ", hiddenword));

            int mistakes = 0;

            char letter = Console.ReadKey().KeyChar;

            while (mistakes < 6)
            {

                for (int i = 0; i < word.Length; i++)
                {
                    if (letter == word[i])
                    {
                        hiddenword[i] = letter;
                    }
                }

                Console.WriteLine("\n{0}", string.Join(" ", hiddenword));
                letter = Console.ReadKey().KeyChar;
            }
        }
    }
}
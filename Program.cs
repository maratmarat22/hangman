using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;

namespace виселица
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //меню
            Hangman hangman = new Hangman();
            
            Console.WriteLine("1 - начать игру\n2 - список лидеров");
            
            int menuchoice = int.Parse(Console.ReadLine());
            bool gamestart = false, leaderboard = false;

            switch (menuchoice)
            {
                case 1:
                    gamestart = true; break;
                case 2:
                    leaderboard = true; break;
            }

            //один уровень
            if (gamestart)
            {
                string word = "виселица";
                char[] hiddenword = new char[word.Length];

                for (int i = 0; i < word.Length; i++)
                {
                    hiddenword[i] = '_';
                }

                Console.WriteLine("{0}", string.Join(" ", hiddenword));

                int mistakes = 0;
                int MaxMistakes = 6;

                while (mistakes < MaxMistakes && new string(hiddenword) != word)
                {
                    char letter = Console.ReadKey().KeyChar;
                    bool letterFound = false;

                    for (int i = 0; i < word.Length; i++)
                    {
                        if (letter == hiddenword[i])
                        {
                            Console.WriteLine("\nВы уже вводили {0}", letter);

                            letterFound = true;
                            break;
                        }

                        if (letter == word[i])
                        {
                            hiddenword[i] = letter;
                            letterFound = true;
                        }
                    }
                    if (!letterFound)
                    {
                        mistakes++;
                    }

                    Console.WriteLine("\n{0}", string.Join(" ", hiddenword));
                    Console.WriteLine("Ошибок: {0}", mistakes);
                    Hangman.Output(mistakes);
                }

                if (mistakes == MaxMistakes)
                {
                    Console.WriteLine("Вы проиграли");
                }
                else
                {
                    Console.WriteLine("Вы выиграли");
                }
                Console.ReadKey();                
            }
            
            //список лидеров
            if (leaderboard)
            {
                Console.WriteLine("1 - петя\n2 - вася\n3 - коля");
            }
        }
    }
}
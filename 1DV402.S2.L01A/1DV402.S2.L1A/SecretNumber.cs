using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S2.L1A
{
    public class SecretNumber
    {
        //Variabler
        public const int MaxNumberOfGuesses = 7;
        private int _count;
        private int _number;

        public void Initialize()
        {
            //Initierar program, sätter _count till 0 och _number till ett slumpmässigt tal mellan 1-100
            _count = 0;
            Random value = new Random();
            _number = value.Next(1, 101);
        }

        public bool MakeGuess(int number)
        {

            if (_count < MaxNumberOfGuesses)
            {
                ++_count;

                if (number < 1 || number > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }

                else if (number > _number)
                {
                    Console.WriteLine("Talet {0} är för stort! Kvarvarande gissningar: {1}", number, (MaxNumberOfGuesses - _count));
                }
                else if (number < _number)
                {
                    Console.WriteLine("Talet {0} är för litet! Kvarvarande gissningar: {1}", number, (MaxNumberOfGuesses - _count));
                }

                else if (number == _number)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Korrekt! Du klarade det på {0} gissningar!", _count);
                    Console.ResetColor();
                    return true;
                }
                
                if (_count == MaxNumberOfGuesses)
                {
                    Console.WriteLine("Du har misslyckats! Talet som söktes var {0}!", _number);
                }
                
                return false;
                
                //...kasta ett undantag.
            }

            else
            {
                throw new ApplicationException();
            }


        }

        public SecretNumber()
        {
            Initialize();
        }
    }
}




















//{
//    class SecretNumber
//    {
//        int _count;
//        int _secretNumber;
//        public const int MaxNumberOfGuesses = 7;

//        public void Initialize()
//        {
//            _count = 1;
//            Random rand = new Random();
//            _secretNumber = rand.Next(101);
//        }

//        public bool MakeGuess(int number)
//        {
//            if (_secretNumber == number)
//            {
//                Console.WriteLine("Rätt gissat! Du klarade det på {0} gissningar!", _count);
//                return true;
//            }

//            if (_secretNumber > number)
//            {
//                Console.WriteLine("{0} är för lågt, försök igen. Du har {1} gissningar kvar!", number, (MaxNumberOfGuesses - _count));
//                _count++;
//            }

//            if (_secretNumber < number)
//            {
//                Console.WriteLine("{0} är för högt, försök igen. Du har {1} gissningar kvar!", number, (MaxNumberOfGuesses - _count));
//                _count++;
//            }

//            return false;
//        }


//        public SecretNumber()
//        {
//            Initialize();
//        }


//    }
//}


















//++_count;

//do
//{
//    if (number > _number)
//    {
//        Console.WriteLine("Talet du gissade är för stort!");
//        return false;
//    }
//    if (number < _number)
//    {
//        Console.WriteLine("Talet du gissade är för litet!");
//        return false;
//    }
//    if (number < 1 || number > 100)
//    {
//        Console.BackgroundColor = ConsoleColor.Red;
//        Console.WriteLine("Fel! Talet måste vara mellan 1-100. Försök igen");
//        Console.ResetColor();
//        throw new ArgumentOutOfRangeException();
//    }
//    if (number == _number)
//    {
//        Console.BackgroundColor = ConsoleColor.Green;
//        Console.WriteLine("Korrekt!");
//        Console.ResetColor();
//        return true;
//    }
//    if (_count > MaxNumberOfGuesses)
//    {
//        throw new ApplicationException();
//    }

//} while (_count < MaxNumberOfGuesses);

//return false;
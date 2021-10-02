using System;
using System.Collections.Generic;
using System.Text;
enum Menu{
    Playgame = 1,
    Exit
}
namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = 6;
            int count = 0;
            HeadScreenGameHangMan();
            Console.Write("Please Select Menu: ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            //เงื่อนไขไปหน้าแต่ละหน้า
            if (menu == Menu.Playgame)
            {
                HeadToPlayGame();

                Random random = new Random();

                string[] arrayword = { "Tennis", "Football", "Badminton" };

                string wordToGuess = arrayword[random.Next(0, arrayword.Length)];
                string wordToGuessUppercase = wordToGuess.ToUpper();

                StringBuilder displayToPlayer = new StringBuilder(wordToGuess.Length);
                for (int i = 0; i < wordToGuess.Length; i++)
                    displayToPlayer.Append('_');

                List<char> correctGuesses = new List<char>();
                List<char> incorrectGuesses = new List<char>();
                bool won = false;
                int lettersRevealed = 0;

                string input;
                char guess;
                //รับคำตอบจนกว่าจะครบตามอักษรที่สุ่มมาได้
                while (!won && lives > 0)
                {
                    //รักตัวอักษรจากผู้เล่น
                    Console.Write("Input letter alphabet: ");

                    input = Console.ReadLine().ToUpper();
                    guess = input[0];
                    if (wordToGuessUppercase.Contains(guess))
                    {
                        Console.Clear();
                        HeadToPlayGame();
                        correctGuesses.Add(guess);

                        for (int i = 0; i < wordToGuess.Length; i++)
                        {
                            if (wordToGuessUppercase[i] == guess)
                            {
                                displayToPlayer[i] = wordToGuess[i];
                                lettersRevealed++;
                            }
                        }

                        if (lettersRevealed == wordToGuess.Length)
                            Console.Clear();
                            HeadToPlayGame();
                        won = true;
                    }
                    else
                    {
                        Console.Clear();
                        HeadToPlayGame();
                        incorrectGuesses.Add(guess);
                        //แสดงค่าที่ผู้เล่นกรอกผิด
                        Console.WriteLine("Incorrect Score: {0}", count);
                        lives--; count++;
                    }

                    Console.WriteLine(displayToPlayer.ToString());
                }
                //แยก แพ้ชนะ แล้วจบการทำงาน
                if (won)
                    Console.WriteLine("You won!");
                else
                    Console.WriteLine("Game Over");
            }
            else if (menu == Menu.Exit) { Console.WriteLine(); }


            Console.ReadLine();
        }
        //หน้าเล่นเกม
        static void HeadToPlayGame()
        {
            Console.Clear();
            Console.WriteLine("Play Game Hangman");
            Console.WriteLine("-----------------");
        }
        //หน้าแรกกับลิสตัวเลือก
        static void HeadScreenGameHangMan()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Hangman Game");
            Console.WriteLine("-----------------------");
            Console.WriteLine("1. Play game");
            Console.WriteLine("2. Exit");
        }
    }

}
   


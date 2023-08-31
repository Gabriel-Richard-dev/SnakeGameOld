using System;

namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var tab = new Tabuleiro();
            Snake snake = new Snake();
            tab.CriaTabuleiro();
            tab.InsereSnake(snake);
            var key = ConsoleKey.F1;

            do
            {
                key = snake.Move(tab, key);
                
            } while (true);

        }
        
    }
}
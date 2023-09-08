using System;


namespace SnakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var tab = new Tabuleiro();
            Snake snake = new Snake();
            Fruit fruit = new Fruit();
 
            tab.CriaTabuleiro();
            tab.InsereSnake(snake, fruit);
            var key = ConsoleKey.F1;


            while (true)
            {
                key = snake.Move(tab, fruit, key);
                snake.Eat(fruit);
                
                ContinuaJogando(snake);
                
            } 
        }

        static void ContinuaJogando(Snake snake)
        {
            if (snake.Ganhou())
            {
                Parabens();
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (snake.Morreu())
            {
                Perdeu();
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
        static void Parabens()
        {
            Console.WriteLine("Parabéns você ganhou!");
        }    
        static void Perdeu()
        {
            Console.SetCursorPosition(13, 10);

            Console.Write("----------- VOCÊ PERDEU --------");
            
            Console.SetCursorPosition(0, 24);

            Environment.Exit(0);
        }   
    }
}
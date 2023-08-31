namespace SnakeGame;

public class Tabuleiro
{
    private int linha = 20;
    private int colunas = 60;

    public void CriaTabuleiro()
    {
        Console.Clear();
        
        for (int c = 0; c < colunas; c++)
        {
            Console.Write("#");
        }
        Console.WriteLine();
        for (int l = 0; l < linha; l++)
        {
            Console.Write("#");

            for (int i = 0; i < (colunas - 2); i++)
            {
                Console.Write(" ");
            }
            
            Console.Write("#\n");
        }
        for (int c = 0; c < colunas; c++)
        {
            Console.Write("#");
        }
        
        Console.WriteLine();
    }

    public void InsereSnake(Snake py, ConsoleKey key = ConsoleKey.F1)
    {
        int contHori = 0;
        int contVert = 0;
        Console.SetCursorPosition(py.GetHorizontal(), py.GetVertical());
        for (int i = 0; i < py.GetTamanho(); i++)
        {
            Console.Write("█");
            if (key == ConsoleKey.F1)
            {
                py.SetHorizontal(1);    
            }
            else
            {
                switch (key)
                {
                    case ConsoleKey.UpArrow: contVert--; break; 
                    case ConsoleKey.DownArrow: contVert++; break; 
                    case ConsoleKey.LeftArrow: contHori--; break; 
                    case ConsoleKey.RightArrow: contHori++; break; 
                }
            }
            
            Console.SetCursorPosition((py.GetHorizontal() + contHori), (py.GetVertical() + contVert));
        }

        Console.SetCursorPosition(0, 24);
    }
}

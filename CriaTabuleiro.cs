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

    public void InsereSnake(Snake py, Fruit fruit, ConsoleKey key = ConsoleKey.F1)
    {
        Console.CursorVisible = false;
        try
        {
            Console.SetCursorPosition(py.GetHorizontal(), py.GetVertical());
            
        }
        catch
        {
            
            return;
        }
        
        
       
        if (key == ConsoleKey.F1)
            py.SetHorizontal(1);
        fruit.InsereFruta();
        foreach (var s in py.RecebeSnake())
        {
            try
            {
                Console.SetCursorPosition(s[1], s[0]);
                Console.Write("█");
            }
            catch
            {
                
                return;
            }
            
           
            
            
        }   
        
        Console.SetCursorPosition(0, 24);
        Console.Write($"Pontuação: {py.points} | H {py.GetHorizontal()} | V {py.GetVertical()}");
    }


}

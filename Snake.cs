namespace SnakeGame;

public class Snake
{
    public Snake()
    {
        Tamanho = 3;
        Vertical = 10;
        Horizontal = 27;
        Speed = 200;
    }
    
    private int Tamanho { set; get; }
    private int Vertical { set; get; }
    private int Horizontal { set; get; }
    private int Speed { set; get; }
    public ConsoleKey keyhash;
    public int GetTamanho()
    {
        return Tamanho;
    }public int GetVertical()
    {
        return Vertical;
    }public int GetHorizontal()
    {
        return Horizontal;
    }

    public void SetHorizontal(int num)
    {
        Horizontal += num;
    }
    public void SetVertical(int num)
    {
        Vertical += num;
    }

    public ConsoleKey Move(Tabuleiro tb, ConsoleKey key)
    {
        switch (key)
        {
            case ConsoleKey.UpArrow: Vertical--; break; 
            case ConsoleKey.DownArrow: Vertical++; break; 
            case ConsoleKey.LeftArrow: Horizontal--; break; 
            case ConsoleKey.RightArrow:Horizontal++; break;
            default: break;
        }

        if (Console.KeyAvailable)
        {
            keyhash = Console.ReadKey(true).Key;
            if (!(keyhash.Equals(key)))
            {
                key = keyhash;
            }
            
        }
        
        Thread.Sleep(Speed);
        tb.CriaTabuleiro();
        tb.InsereSnake(this, key);
        return key;
    }
}

enum Posicao
{
    Cima, Baixo, Esquerda , Direita
}
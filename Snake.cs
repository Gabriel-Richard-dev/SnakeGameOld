namespace SnakeGame;

public class Snake
{
    public Snake()
    {
        snake = new List<List<int>>();
        
        List<int> cabeca = new List<int>() { 10, 30 };
        List<int> rabo1 = new List<int>() { 10, 29 };
        List<int> rabo2 = new List<int>() { 10, 28 };
        Tamanho = 3;

        snake.Add(cabeca);
        snake.Add(rabo1);
        snake.Add(rabo2);

        _Speed = 400;
    }

    public int points { get; set; }
    public int Tamanho { get; set; }
    private int _Speed { get; set; }
    private List<List<int>> snake { get; set; }
    public ConsoleKey keyhash;

    public int GetSpeed()
    {
        return _Speed;
    }

    public int GetTamanho()
    {
        return snake.Count;
    }public int GetVertical()
    {
        return snake[0][0];
    }public int GetHorizontal()
    {
        return snake[0][1];
    }

    public void SetHorizontal(int num)
    {
        for (int s = GetTamanho() - 1; s > 0; s--)
        {
            snake[s][0] = snake[s - 1][0];
        }
        for (int s = GetTamanho() - 1; s > 0; s--)
        {
            snake[s][1] = snake[s - 1][1];
        }

        snake[0][1] += num;
    }

    
    public void SetVertical(int num)
    {
        for (int s = GetTamanho() - 1; s > 0; s--)
        {
            snake[s][1] = snake[s - 1][1];
        }
        for (int s = GetTamanho() - 1; s > 0; s--)
        {
            snake[s][0] = snake[s - 1][0];
        }

        snake[0][0] += num;
    }

    public List<List<int>> RecebeSnake()
    {
        return snake;
    }

    public bool Morreu(bool force = false)
    {
        if (GetHorizontal() == 60 
            || GetVertical() == 20
            || GetHorizontal() == 0
            || GetVertical() == 0
            || SeBateu() == true)
        {
            return true;
        }
        return false;
    }

    public bool SeBateu()
    {
        for (int s = 1; s < GetTamanho() - 1; s++)
        {
            if (snake[0][0] == snake[s][0] & snake[0][1] == snake[s][1])
            {
                return true;
            }
        }

        return false;
    }

    public bool Ganhou()
    {
        if (Tamanho == 1160)
        {
            return true;
        }

        return false;
    }
    public void Eat(Fruit ft)
    {
        List<int> newRabo = new List<int>();
        if (snake[0][0] == ft.vertical & snake[0][1] == ft.horizontal)
        {
            newRabo.Add(snake[GetTamanho()-1][0]);
            newRabo.Add(snake[GetTamanho()-1][1]);
            snake.Add(newRabo);
            ft.randomFruta();
            _Speed -= 50;
            Tamanho++;
            points += 50;
        }
    }
    public ConsoleKey Move(Tabuleiro tb, Fruit ft,ConsoleKey key)
    {
        switch (key)
        {
            case ConsoleKey.UpArrow:
            {
          
                    SetVertical(-1);
              
                break;
                
            }
            case ConsoleKey.DownArrow:
            {
                {
                    
                    
                    SetVertical(1);
                    

                    break;
                } 
            } 
            case ConsoleKey.LeftArrow: 
            {
 
                    SetHorizontal(-1);
            
                break;
            } 
                 
            case ConsoleKey.RightArrow: 
            {
      
                    SetHorizontal(1);
                
                break;
            } 
        }

        if (Console.KeyAvailable)
        {
            keyhash = Console.ReadKey(true).Key;
            if (!(keyhash.Equals(key)))
            {
                key = keyhash;
            }
            
        }

        Thread.Sleep(GetSpeed());
        tb.CriaTabuleiro();
        tb.InsereSnake(this, ft, key);
        return key;
    }
}


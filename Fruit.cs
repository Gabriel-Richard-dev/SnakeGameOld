namespace SnakeGame;

public class Fruit
{
    public Fruit()
    {
        rand = new Random();
        randomFruta();
    }

    private Random rand;
    public int horizontal { get; set; }
    public int vertical { get; set; }
    
    
    public string fruitchar = "\u25cf";

    public void randomFruta()
    {
        horizontal = (rand.Next() % 58) + 1;
        vertical = (rand.Next() % 8) + 1;
    }

    public void InsereFruta()
    {
        Console.SetCursorPosition(horizontal, vertical);
        Console.Write(fruitchar);
        Console.SetCursorPosition(0,24);
    }
    
}
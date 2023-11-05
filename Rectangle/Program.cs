using System;

class Rectangle
{
    private int height;
    private int width;
    private char symbol;

    public Rectangle()
    {
        height = 1;
        width = 1;
        symbol = '*';
    }

    public Rectangle(int height, int width)
    {
        this.height = height;
        this.width = width;
        symbol = '*';
    }

    public Rectangle(int height, int width, char symbol)
    {
        this.height = height;
        this.width = width;
        this.symbol = symbol;
    }

    public void Print(bool filled)
    {
        for (int i = 0; i < height; i++)
        {
            if (filled || i == 0 || i == height - 1)
            {
                Console.WriteLine(new string(symbol, width));
            }
            else
            {
                Console.WriteLine(symbol + new string(' ', width - 2) + symbol);
            }
        }
    }
}

class Program
{
    static void Main()
    {
        
        Rectangle rect1 = new Rectangle(3, 5, '#');
        rect1.Print(false);  
      
        Rectangle rect2 = new Rectangle(4, 4, 'X');
        rect2.Print(true); 
    }
}


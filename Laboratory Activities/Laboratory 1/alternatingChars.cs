using System;
class HelloWorld {
  static void Main() {
      
    Console.Write("First character: ");
    char first_char = char.Parse(Console.ReadLine());
    Console.Write("Second character: ");
    char second_char = char.Parse(Console.ReadLine());
    Console.Write("Enter size: ");
    int size = int.Parse(Console.ReadLine());
    
    for (int i=1; i<=size; i++)
    {
        if (i==1)
        {
            Console.Write(first_char);
        }
        else
        {
            for (int j=1; j<=i; j++)
            {
                if (i%2==0)
                {
                    if (j!=i)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(second_char);
                    }
                }
                else
                {
                    if (j!=i)
                    {
                        Console.Write("-");
                    }
                    else
                    {
                        Console.Write(first_char);
                    }
                }
            }
        }
        Console.WriteLine("");
    }
  }
}

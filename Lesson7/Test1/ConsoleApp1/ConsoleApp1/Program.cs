class Program
{
    static public void Main(string[] args)
    {
        if (args.Length >=1)
        {
            if (args[0] == "")
            Console.WriteLine($"Hello, {args[0].Replace("-", "")}!");
         
        }
        
        Console.ReadKey();
    }
}


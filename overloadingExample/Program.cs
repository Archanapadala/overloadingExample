namespace overloadingExample
{
    public class MathOperat
    {
        public int Add(int x , int y)
        {
            return x + y;
        }

        public double Add(double x , double y)
        {
            return x + y;
        }
         public string Add(string x , string y)
        {
            return x + y;
        }

        class Program
        {
            static void Main(string[] args)
            {
                MathOperat math = new MathOperat();

                Console.WriteLine("Adding two integers:" + math.Add(5, 3));
                Console.WriteLine("Adding two doubles:" + math.Add(5.5, 3.3));
                Console.WriteLine("two strings :" + math.Add("Hello", "team"));
            }
        }

    }
}

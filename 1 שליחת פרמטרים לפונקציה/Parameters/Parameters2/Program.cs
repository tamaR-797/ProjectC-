namespace Parameters2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 10;
            int c;

            Console.WriteLine(SumAndSubOut(a, b, out c));
            Console.WriteLine($"{a}-{b}={c}");

            Console.WriteLine(SumAndSub(a, b, ref c));
            Console.WriteLine($"{a}-{b}={c}");


            Class1 c1 = new Class1() { X = 6, Y = 7 };
            ChangeClass1(c1);
            Console.WriteLine(c1);
            ChangeClass1Ref(ref c1);
            Console.WriteLine(c1);

            Console.WriteLine("========================");
            Console.WriteLine(SumAll(3, 5, new int[] { 3, 4, 56, 7 }));
            Console.WriteLine(SumAll(3, 5, 3, 4, 56, 7));
            Console.WriteLine(SumAll(3, 5, numbers: new int[] { 3, 4, 56, 7 }));
            Console.WriteLine(SumAll(3, 5));

            f(1, true, "jvkf", 'h', c);

            Console.WriteLine(Sub(a: a, b, n: 5));
            Console.WriteLine(Sub(b: a, a: b, isAbs: false, n: 5));

            //int x1, x2, x3;
            //double x4;
            (int x1, int x2, int x3, double x4) = MyMath(3, 5);
            var (x5, x6, x7, x8) = MyMath(3, 5);

            var v = 9;
            //v = "jgk";

            var result = MyMath(1, 2);
            Console.WriteLine(result.Item1);
            Console.WriteLine(result.Item2);
            Console.WriteLine(result.Item3);
            Console.WriteLine(result.Item4);

            result = MyMath(7, 8);
            //result = 9;

            var cl = new { a = 9, b = true, c = 'y' };
            cl = new { a = 39, b = false, c = 't' };
            //cl = new { A = 39, b = false, c = 't' };
            
        }

        public static (int, int, int, double) MyMath(int x, int y)
        {
            return (x + y, x - y, x * y, x / y);
        }

        public static int Sub(int a, int b, bool isAbs = false, int n = 0)
        {
            return isAbs ? Math.Abs(a - b) : a - b;
        }

        public static void f(params object[] objects)
        {
            foreach (object obj in objects)
                Console.WriteLine(obj);
        }

        public static int SumAll(int x, int y, params int[] numbers)
        {
            int sum = x + y;
            foreach (int i in numbers)
                sum += i;
            return sum;
        }

        public static void ChangeClass1(Class1 c)
        {
            c = new Class1();
            c.Y = c.X;
            c.X = 1;
        }

        public static void ChangeClass1Ref(ref Class1 c)
        {
            c = new Class1();
            c.Y = c.X;
            c.X = 1;
        }
        public static int SumAndSub(int x, int y, ref int z)
        {
            x = 8;
            z = x - y;
            return x + y;
        }
        public static int SumAndSubOut(int x, int y, out int z)
        {
            //Console.WriteLine(z);
            z = x - y;
            return x + y;
        }


    }
}

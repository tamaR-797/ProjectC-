using System.Text;

namespace Parameters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1() { MyInit = 5,/* MyInt=3 ,MyProperty=4*/ };
            c.X = 4;
            Console.WriteLine(c.X);
            //c.MyProperty = 9; שגיאה
            Console.WriteLine(c.MyProperty);
            c.Y = 5;
            //c.MyInit = 9; שגיאה

            int a = 5;
            int b = 3;
            Console.WriteLine(a + "+" + b + "=" + a + b);
            Console.WriteLine($"{a}+{b}={a+b}");
            Console.WriteLine(@"MyFolder\""newFile"".docx");
            Console.WriteLine("MyFolder\\\"newFile\".docx");

            string s = "fjkdkl";
            s += "AAAAA";
            //s[2] = 'g';
            char c2 = s[4];

            StringBuilder sb = new StringBuilder("hjdgc");
            sb.Append("jkc");
            sb.AppendLine(s);
            sb.Append("jkldc");
            sb[3] = '4';

            Console.WriteLine(sb);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    public class Class1
    {
		public int Y;
        public int MyProperty { get; private set; }

		public readonly int MyInt;

        public int MyProperty1 { get; }
		public int MyInit { get; init; } = 9;

        private int x;

		public int X
		{
			get 
			{
				return 10;
			}
			set 
			{
				if (value < 10)
					x = value + 5;
				else
					x = value;
			}
		}

		public void f()
		{
			MyProperty++;
			//MyProperty1 = 5;
			//MyInit = 8; שגיאה!
        }

        public Class1()
        {
			MyProperty1 = 7;
			MyInit = 9;
        }

        public override string ToString()
		{
			//return "My Class1 MyInit= " + MyInit + " MyProperty1=" + MyProperty1;
			return $"My Class1 MyInit= {MyInit} MyProperty1={MyProperty1}";
	
		}
	}
}

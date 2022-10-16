using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For04
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//int i 1~20
			//3*,print foo
			//5*,print bar
			//15*,print foobar
			//else, print int
			
			for (int i = 1; i <=20; i++)
			{
				const int target1 = 3;
				const int target2 = 5;
				if (i % (target1 * target2) == 0)
				{
					Console.WriteLine("foobar");
				}

				if (i%target1==0)
				{
					Console.WriteLine("foo");
				}else if(i%target2==0)
				{
					Console.WriteLine("bar");
				}else
				{
					Console.WriteLine(i);
				}
			}

		}
	}
}

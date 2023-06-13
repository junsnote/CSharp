/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace FinalQ2
{
	class MainApp
	{
		static void Main(string[] args)
		{
			Queue que = new Queue();
			que.Enqueue(100);
			que.Enqueue(200);
			que.Enqueue(300);
			que.Enqueue(400);
			que.Enqueue(500);
			Console.WriteLine($"{que.Dequeue()}");
			Console.WriteLine($"{que.Peek()}");
			Console.WriteLine($"{que.Dequeue()}");
			Console.WriteLine($"{que.Dequeue()}");
		}
	}
}
*/

/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalQ2
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 15 };
			var result = from n in numbers
						 where n % 3 == 0
						 orderby n ascending
						 select n;

			foreach (int i in result)
			{
				Console.WriteLine($"{i} ", i);
			}
		}
	}
}
*/
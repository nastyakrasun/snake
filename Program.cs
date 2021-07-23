using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
			Point p1 = new Point(1, 3, '*');
			/*p1.Draw();*/

			Point p2 = new Point(4, 5, '#');
			/*p2.Draw();*/

			Point p3 = new Point(15, 7, '@');
			/*p3.Draw();*/

			Point p4 = new Point(24, 15, '&');
			/*p4.Draw();*/

			Point p5 = new Point(9, 11, '%');
			/*p5.Draw();*/

			HorisontalLine line = new HorisontalLine();
			line.Draw();

			Console.ReadLine();
		}

	}
}

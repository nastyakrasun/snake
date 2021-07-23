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

			Console.WriteLine();
			Console.WriteLine();

			List<int> numList = new List<int>();
			numList.Add(100);
			numList.Add(200);
			numList.Add(300);

			int x = numList[0];
			int y = numList[1];
			int z = numList[2];

			foreach(int i in numList)
            {
				Console.WriteLine(i);
            }

			numList.RemoveAt(0);

			Console.WriteLine();

			List<Point> pList = new List<Point>();
			pList.Add(p1);
			pList.Add(p2);
			pList.Add(p3);
			pList.Add(p4);
			pList.Add(p5);

			foreach (Point i in pList)
			{
				i.Draw();
			}
			
			Console.WriteLine();

			List<char> symList = new List<char>();
			symList.Add('&');
			symList.Add('*');
			symList.Add('#');

			char a = symList[0];
			char b = symList[1];
			char c = symList[2];

			foreach (char i in symList)
			{
				Console.WriteLine(i);
			}

			Console.ReadLine();
		}

	}
}

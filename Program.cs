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
			// устанавлиает размер окна
			//Console.SetBufferSize(80, 25);

			// отрисовка рамочки
			HorisontalLine upline = new HorisontalLine(0, 48, 0, '*');			
			HorisontalLine downline = new HorisontalLine(0, 48, 24, '*');			
			VerticalLine leftline = new VerticalLine(0, 0, 24, '*');			
			VerticalLine rightline = new VerticalLine(48, 0, 24, '*');
			
			upline.Draw();
			downline.Draw();
			leftline.Draw();
			rightline.Draw();

			// отрисовка точки
			Point p = new Point(4, 5, '%');
			Snake snake = new Snake(p, 4, Direction.RIGHT);
			snake.Draw();
			snake.Move();
            System.Threading.Thread.Sleep(300);
			snake.Move();
			System.Threading.Thread.Sleep(300);
			snake.Move();
			System.Threading.Thread.Sleep(300);
			snake.Move();
			System.Threading.Thread.Sleep(300);
			snake.Move();


			Console.ReadLine();
		}

	}
}

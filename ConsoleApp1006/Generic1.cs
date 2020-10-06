using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1006
{
	//메서드가 너무 많아지면 클래스를 따로만들어 관리하면 편하지 않을까
	//제네릭
	class Calc<T>
	{
		public T Add(T x, T y)
		{
			dynamic dx = x; //T에 뭐가올지 모르기때문에 +연산자가 모든타입에 있지않기 때문에 
			dynamic dy = y; // dynamic 예약어를 사용해 실행할때로 판단을 미루는 것
			return dx + dy;  
		}
		public T Minus(T x, T y)
		{
			dynamic dx = x; 
			dynamic dy = y;
			return dx - dy;
		}
	}
	class Generic1
	{
		
		static void Main()
		{
			int x = int.Parse(Console.ReadLine());
			int y = int.Parse(Console.ReadLine());

			Calc<int> c1 = new Calc<int>();
			//Console.WriteLine(Add(x, y));

			Console.WriteLine(c1.Add(3,5));
			//Console.WriteLine(c1.Minus(3.5, 5.7)); //int를 가리키기 때문에 double형은 오류

			Calc<double> c2 = new Calc<double>();
			c2.Add(3.5, 6.7);
			c2.Minus(2, 5); // 이경우는 double이 int로 자동형변환
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1006
{
	class IntegerText
	{
		char[] txtNumber;
		public char this[int idx] //GetPointNumber를 인덱스로 바꿔서 사용
		{
			get { return txtNumber[txtNumber.Length - (idx + 1)]; }
			set { txtNumber[txtNumber.Length - (idx + 1)] = value; }
		}
		public IntegerText(int number)
		{
			txtNumber = number.ToString().ToCharArray();
		}
		public char GetPointNumber(int point)
		{
			return txtNumber[txtNumber.Length - (point + 1)];
		}
	}

	class Indexer1
	{
		static void Main()
		{
			int step = 1;
			IntegerText c1 = new IntegerText(123456);

			for (int i = 0; i < 6; i++)
			{
				//Console.WriteLine($"{step}의 자릿수 " + c1.GetPointNumber(i));
				// 자릿수 뽑는데 메서드를 사용해도 문제는 없지만 메서드 없이 뽑고싶으면 인덱스 사용
				Console.WriteLine($"{step}의 자릿수 " + c1[i].ToString()); // 인덱서 사용
				step *= 10;
			}
		}
	}
}

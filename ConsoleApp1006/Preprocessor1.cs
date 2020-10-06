using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1006
{
	class Preprocessor1
	{
		static void Main()
		{
#if REAL //이렇게 전처리기 지시문을써 프로젝트 속성 안에 빌드탭에 조건부 컴파일 기호를 입력하면 주석처리 안해도 자유롭게 바꿀수있다
			string name = Console.ReadLine();
			string pwd = Console.ReadLine();
#endif
#if DEBUG
			string name = "홍길동"; //개발할때는 매번 입력하기 귀찮으니까 입력을 주석하고 값을 줘버림
			string pwd = "1234";
			//하지만 주석을 계속 왔다갔다 하기 너무 귀찮음
#endif
			Console.WriteLine("아이디");
			Trace.WriteLine(name);
		}
	}
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1006
{
	class Dictionary1
	{
		static void Main(string[] args)
		{
			Hashtable ht = new Hashtable();
			ht.Add(10, "오렌지");
			ht[10] = "딸기";
			ht[20] = "사과"; //값이 없으면  Add가 됨 있으면 업데이트
			//ht.Add(20, "복숭아");// 하지만 Add로 값이 중복되었으면 오류가 뜸(컴파일단계에선 오류나지않음)

			Console.WriteLine(ht.Count);

			Dictionary<int, string> dic = new Dictionary<int, string>();
			dic.Add(10, "오렌지");
			dic[10] = "딸기";
			dic[20] = "사과";
			//dic["수박"] = 100; // Dictionary는 컴파일부터 오류가남
			// 이유는 HashTable은 Object로 선언되서 뭐가 들어올지 모르기때문에 컴파일 단계에서 에러가 나지않지만
			//Dictionary는 타입이 정해져있기 떄문에 컴파일부터 오류가 나는거임

			foreach(int elem in dic.Keys)
			{
				Console.WriteLine(dic[elem]);

			}
			foreach (/*KeyValuePair<int, string>*/var elem in dic) //KeyValuePair타입
			{
				Console.WriteLine($"{elem.Key} - {elem.Value}");
			}
			//비슷하지만 다르다
			// var 타입 = 타입이 기억이 나지 않을때 알아서 타입을 찾아줌
			var name = "홍길동";
			Console.WriteLine(name);

			name = 10.ToString(); //var는 처음에 선언할때 타입이 정해지기 때문에 값을줄때 값에 따라 타입이 변하지는 않는다
		}
	}
}

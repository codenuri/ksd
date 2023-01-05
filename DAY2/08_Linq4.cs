using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 지연된 실행, ToList(), 캡쳐된 변수

class Program
{
    public static void Main()
    {
        List<int> list = new List<int> { 1, 2, 3 };

        // LINQ 핵심 : 지연된 실행
        // => 아래 코드는 result 가 list 와 수행할 함수를 보관하고 있다가
        //    요소를 열거 할때 실행 합니다.
        // Select : 기존 요소에 연산한 수행한 결과를 얻기(Select)
        //var result = list.Select(n => n * 10);
        

        // 즉시 결과를 얻으려면 ToList() 를 사용하세요(또는 ToXXX() 메소드)
        // => 반환 타입은 "IEnmerable<int>" 가 아닌 "List<int>" 입니다.
        var result = list.Select(n => n * 10).ToList();


        list.Add(4);
        list.Add(5);

        foreach (int n in result)  
            Console.WriteLine(n);  // 10, 20, 30
    }
}





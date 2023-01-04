using System;
using System.Security.Principal;

// indexer : 객체를 배열처럼
class Sentense
{
    protected string[] words;
    public Sentense(string s) { words = s.Split(); }

    // indexer : 객체를 배열처럼 [] 연산자를 사용하게 하는 문법
    // => C++ : "operator[]" 연산자 재정의와 같은 개념

    // 프라퍼티에 거의 유사 합니다.
    // => 이름 위치에 "this[int idx]" 만 다릅니다.
    public string this[int idx]
    {
        get { return words[idx]; }
        set { words[idx] = value; }
    }

    public string this[int idx1, int idx2]
    {
        get { return words[idx1] + words[idx2]; }
    }
}

class Program
{
    public static void Main()
    {
//      string s2 = "we are the world";
//      string[] arr = s2.Split(); // 문자열을  단어의 배열로 생성
        Sentense s = new Sentense("we are the world");

        string s1 = s[3]; // "world" 
        
        Console.WriteLine(s1);
        
        s[3] = "frield";

        Console.WriteLine(s[3]);
        //=======================
        // C#은 2차 배열은 arr[0, 0] 형식 입니다.
        Console.WriteLine(s[3, 0]);
    }
}






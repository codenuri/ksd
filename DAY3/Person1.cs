// Person1.cs
using System;

// 아래 처럼 만들면
// => Person 객체의 속성이 변경될때
// => Person 객체와 연결된 UI 가 Update 될수 없습니다.
// => 해결책은 Person2.cs 참고
public class Person
{
    public string name;
    public string addr;

    public String Name
    {
        get { return name; }
        set { name = value; }
    }
    public String Address
    {
        get { return addr; }
        set { addr = value; }
    }
}

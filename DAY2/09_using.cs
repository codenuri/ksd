// 09_using
using System;
using System.IO;

class Program
{
    public static void Foo()
    {
        FileStream fs = new FileStream("a.txt", FileMode.Create);

        byte[] buf = new byte[1024];

        fs.Write(buf, 0, 1024);

        // file 작업을 다한후에 닫지 않아도 자동으로 닫히기는 합니다.
        // => 그런데, 되도록이면 즉시 닫으세요.
        fs.Dispose();
    }
    public static void Goo()
    {
        // using block 을 사용하면 {}을 벗어날때 자동으로 Dispose() 됩니다.
        using (FileStream fs = new FileStream("a.txt", FileMode.Create))
        {
            byte[] buf = new byte[1024];

            fs.Write(buf, 0, 1024);
        }

        // 파일, DB, 네트워크 등의 시스템 자원을 사용하는 클래스는
        // Dispose() 를 호출하는 것을 권장합니다.
        // => 되도록 직접 호출하지 말고 using {} 을 사용하세요!!!
    }



    public static void Main()
    {
        Foo();
    }
}
// 어셈블리를 참조 한다는 것 : 해당 타입이 어느 DLL 에 있는지 알려주는것
// using KSD 하는 것 : 소스에서 KSD 이름 공간에 있는 것을 KSD 없이 사용
//                    (어셈 블리가 참조 되어 있는 상태에서... )

// using_ksd.cs
using KSD;

class Program
{
    public static void Main()
    {
        //KSD.Machine m = new KSD.Machine();

        Machine m = new Machine();

        m.Run();
    }
}
// 명령프롬프트에서 빌드하세요
// csc using_ksd.cs     => KSD.Machine 을 찾을수 없다는 에러

// csc using_ksd.cs /r:ksd.dll
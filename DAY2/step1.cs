// step1

// 핵심 1. WPF 를 사용하기 위한 어셈블리
// PresentationCore
// PresentationFramework
// System
// System.Xaml
// WindowsBase

// 핵심 2. WPF 프로그램이 지켜야 하는 규칙
// => System.Windows.Application 에서 파생 된 클래스 만들고
// => 객체를 생성후, Run() 호출
// => 관례적으로 Main 메소드도 클래스에 추가 합니다.

using System;
using System.Windows;

class App : Application
{
    public static void Main()
    {
        App app = new App();
        app.Run();
    }
}

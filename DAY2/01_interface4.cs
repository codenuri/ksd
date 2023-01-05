using System;

// 강한 결합(tightly coupling)
// => 하나의 클래스가 다른 클래스 사용시 클래스 이름을 직접 사용하는 것
// => 교체 불가능한 경직된 디자인

// 약한 결합(loosely coupling)
// => 하나의 클래스가 다른 클래스 사용시 규칙을 담은 인터페이스를 사용해서 접근하는것
// => 교체 가능한 유연한 디자인



// 모든 카메라 제작자가 지켜야하는 규칙을 먼저 설계 합니다
// 규칙 : 모든 카메라는 아래 인터페이스를 구현해야 한다.!
//      => 모든 카메라는 Take() 가 있어야 한다.
interface ICamera
{
    void Take();
    
}
// ISP : 인터페이스 격리의 법칙. 인터페이스는 기능 별로 분리되어야 한다.
interface IMP3
{
    void PlayMP3();
    void StopMP3();
}

class GoodCamera : ICamera, IMP3
{
    // 3개 함수 구현. 
}


// 진짜 카메라가 없어도. 사용하는 코드를 작성할수 있습니다.
// 규칙대로만 사용하면 됩니다.
class People
{
    public void UseCamera(ICamera c) { c.Take(); }
}

// 모든 카메라 제작자는 규칙을 지켜야 합니다.
class Camera : ICamera
{
    public void Take() { Console.WriteLine("take picture with Camera"); }
}

class HDCamera : ICamera
{
    public void Take() { Console.WriteLine("take HD picture with HDCamera"); }
}

class UHDCamera : ICamera
{
    public void Take() { Console.WriteLine("take UHD picture with UHDCamera"); }
}

class Coupling
{
    public static void Main()
    {
        People p = new People();
        Camera c = new Camera();
        p.UseCamera(c);

        HDCamera hc = new HDCamera();
        p.UseCamera(hc); 

        UHDCamera uhc = new UHDCamera();
        p.UseCamera(uhc); 
    }
}
using System;


class Camera
{
    public void Take() { Console.WriteLine("take picture with Camera"); }
}

class HDCamera
{
    public void Take() { Console.WriteLine("take HD picture with HDCamera"); }
}

class People
{
    public void UseCamera(Camera c) { c.Take(); }
}

class Coupling
{
    public static void Main()
    {
        People p = new People();
        Camera c = new Camera();
        p.UseCamera(c);

        HDCamera hc = new HDCamera();
        p.UseCamera(hc); //?
    }
}
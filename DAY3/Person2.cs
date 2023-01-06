using System;
using System.ComponentModel;

// 객체 속성 변경시 연결된 UI 를 자동update 되게 하려면
// 반드시, INotifyPropertyChanged 인터페이스를 구현해야 합니다.
// => delegate 가 추가 되는데,
// => UI가 객체에 연결될데, delegate 에 함수를 등록하게 됩니다
// 
public class Person : INotifyPropertyChanged
{
    public string name;
    public string addr;

    public String Name
    {
        get { return name; }

        set { name = value;

            // 객체의 상태가 변경되었으므로 자신에게 등록된 모든 함수를 호출해 준다.
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs("Name"));
        }
    }

    public String Address
    {
        get { return addr; }
        set { addr = value; }
    }
    
    // Person 객체와 연결된 모든 UI는 아래 event 에 함수를 등록하게 됩니다.
    public event PropertyChangedEventHandler PropertyChanged;
}

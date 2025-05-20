using Script;
using UnityEngine;

public class ClassA : MonoBehaviour
{
    public int publicInt=23;
    ClassC c;
    private int privateInt = 33;
    ClassB b;
    //게임을 실행하는 순간 호출하는 콜백함수입니다(일반적인 함수인데 게임 내에 오브젝트가 생성되었을때 실행됩니다.)
    void Start()
    {
        StaticClass.pstaticInt=1;//static 맴버변수 접근
        GameObject go = new GameObject();//gameObject 생성
        go.AddComponent<ClassB>();//gameObject에서 ClassB스크립트 추가
        ClassB b;
        c = new ClassC(10,10);
        c.setHP(101);
        c.setHP(50);
        c.printClass();
        //c.a = 10;//private라서 불가
        c.b = 10;
        b=go.GetComponent<ClassB>();//gameObject에서 ClassB 스크립트를 맴버변수 b에 대입
        b.publicIntB = 10;//퍼블릭 변수라 가능
        //b.privateIntB = 23;//프라이빗 변수라 불가능
    }
}

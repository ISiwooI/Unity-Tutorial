using UnityEngine;

public class ClassC
{
    private int a;
    public int b;
    private int hp;//(0부터 100까지만 가능하게 만들어야함)
/// <summary>
/// 수업에서 진행한 생성자입니다.
/// </summary>
/// <param name="a"></param>
/// <param name="b"></param>
    public ClassC(int a, int b)
    {
        this.a = a;
        this.b = b;
    }

    public void setHP(int hp)
    {
        if (hp < 0 || hp > 100)//체력 범위에서 벗어나는 값을 넣으면?
        {
            return;//함수 그냥 종료
        }

        this.hp = hp;//아니라면 hp수정
    }
    public void printClass()
    {
        Debug.Log(a);
        Debug.Log(b);
    }
}

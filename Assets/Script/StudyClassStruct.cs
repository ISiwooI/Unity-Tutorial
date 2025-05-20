using System.Security.Cryptography;
using UnityEngine;
public class StudyClass
{
    public int number;

    public StudyClass(int number)
    {
        this.number = number;
    }
}
public struct StudyStruct
{
    public int number;

    public StudyStruct(int number)
    {
        this.number = number;
    }
}
public class StudyClassStruct : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("클래스=------------------------------------------");
        StudyClass c1=new StudyClass(10);
        StudyClass c2 = c1;
        Debug.Log($"c1: {c1.number} / c2: {c2.number}");
        c2.number = 100;
        Debug.Log("c2.number=100;");
        Debug.Log($"c1: {c1.number} / c2: {c2.number}");
        Debug.Log("구조체-------------------------------------------");
        StudyStruct s1=new StudyStruct(10);
        StudyStruct s2 = s1;
        Debug.Log($"s1: {s1.number} / s2: {s2.number}");
        s2.number = 100;
        Debug.Log("s2.number=100;");
        Debug.Log($"s1: {s1.number} / s2: {s2.number}");
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}

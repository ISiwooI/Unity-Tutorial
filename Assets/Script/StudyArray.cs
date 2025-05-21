using System;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;

public class StudyArray : MonoBehaviour
{
    [SerializeField]int[] aryInt = new int[5]{1,2,3,4,5};
    [SerializeField]List<int> listInt=new List<int>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {   
            listInt.Add(1);
            listInt.Add(2);
            listInt.Add(3);
            listInt.Add(4);
            
            Debug.Log($"현재 리스트에 있는 데이터 수: {listInt.Count}");
            Debug.Log($"현재 리스트의 마지막 데이터:  {listInt.Last()}");
            foreach (var item in listInt)
            {
                Debug.Log($"리스트 값: {item}");
            }
            Debug.Log($"첫 번째 값{aryInt[0]}");
            Debug.Log($"세 번째 값{aryInt[2]}");
            Debug.Log($"여섯 번째 값{aryInt[5]}");//에러 발생

        }
        catch (IndexOutOfRangeException exception)
        {
            Debug.Log($"OutOfException{exception.Message}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

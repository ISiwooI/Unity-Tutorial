using UnityEngine;

public class StudyHierachy : MonoBehaviour
{
    public GameObject prefab;
    
    // 한글 한글 d2코딩 한글폰트
    void Start()
    {
        CreateCharacter();
    }

    public void CreateCharacter()
    {
        
        GameObject go = Instantiate(prefab);
        go.name = "Character";
        Debug.Log(go.name);
        Debug.Log($"캐릭터의 자식 오브젝트 수: {go.transform.childCount}");
        Debug.Log($"캐릭터의 자식 오브젝트 수: {go.transform.GetChild(0).name})");
        Debug.Log($"캐릭터의 자식 오브젝트 수: {go.transform.GetChild(go.transform.childCount-1).name})");
    }
}

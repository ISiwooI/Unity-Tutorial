using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
public class InputSystemTest : MonoBehaviour
{

    void OnMove(InputValue value)
    {
        Debug.Log(value.Get<Vector2>());
    }
    
}

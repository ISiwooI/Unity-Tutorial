using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(Vector3.forward * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.back * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.A)) 
        { 
            this.transform.Translate(Vector3.left * moveSpeed);
        }
        else if (Input.GetKey(KeyCode.D))
        { 
            this.transform.Translate(Vector3.right * moveSpeed);
        }
    }
}

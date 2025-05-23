using UnityEngine;

public class RotateStudy : MonoBehaviour
{
    private float _roll=0;

    private float _yaw=0;
    private float _pitch=0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _roll=Input.GetAxis("Horizontal")*Time.deltaTime*100f;
        _pitch=Input.GetAxis("Vertical")*Time.deltaTime*100f;
        if (Input.GetKey(KeyCode.Q))
        {
            _yaw=10*Time.deltaTime*10f;
        }
        if (Input.GetKey(KeyCode.E))
        {
            _yaw=-10*Time.deltaTime*10f;
        }

        if (!(Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.E)))
        {
            _yaw = 0;
        }
        transform.rotation*=Quaternion.Euler(_pitch,_roll,_yaw);
    }
}

using UnityEngine;

public class Testing : MonoBehaviour
{
    void Start()
    {
        
    }


    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxis("Horizontal")*0.3f,  
            Input.GetAxis("Vertical")*0.3f, 
            0);
        transform.Translate(vec);
    }
}

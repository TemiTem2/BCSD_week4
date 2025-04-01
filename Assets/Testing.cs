using UnityEngine;

public class Testing : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("키 입력");

        if (Input.anyKey)
            Debug.Log("키 누르는 중");

        if (Input.GetButtonDown("Jump"))
            Debug.Log("점프");
        if (Input.GetButton("Jump"))
            Debug.Log("점프 누르는중");
        if (Input.GetButtonUp("Jump"))
            Debug.Log("점프 뗌");
    }
}

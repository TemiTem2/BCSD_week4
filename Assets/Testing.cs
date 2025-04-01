using UnityEngine;

public class Testing : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("키 입력");

        if (Input.anyKey)
            Debug.Log("키 누르는 중");

        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("엔터 누름");
        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("왼쪽 입력중");
        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 뗌");
        
        
        if (Input.GetMouseButtonDown(0))
            Debug.Log("마우스 입력");
        if (Input.GetMouseButton(0))
            Debug.Log("마우스 누르는중");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("마우스 뗌");
    }
}

using UnityEngine;

public class Testing : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("키 입력");

        if (Input.anyKey)
            Debug.Log("키 누르는 중");

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("횡이동중..."+ Input.GetAxis("Horizontal"));
            
        }

        if (Input.GetButton("Vertical"))
        {
            Debug.Log("종이동중..." + Input.GetAxis("Vertical"));

        }
    }
}

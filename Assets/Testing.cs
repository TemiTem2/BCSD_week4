using UnityEngine;

public class Testing : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("Ű �Է�");

        if (Input.anyKey)
            Debug.Log("Ű ������ ��");

        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("Ⱦ�̵���..."+ Input.GetAxis("Horizontal"));
            
        }

        if (Input.GetButton("Vertical"))
        {
            Debug.Log("���̵���..." + Input.GetAxis("Vertical"));

        }
    }
}

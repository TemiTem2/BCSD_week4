using UnityEngine;

public class Testing : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("Ű �Է�");

        if (Input.anyKey)
            Debug.Log("Ű ������ ��");

        if (Input.GetButtonDown("Jump"))
            Debug.Log("����");
        if (Input.GetButton("Jump"))
            Debug.Log("���� ��������");
        if (Input.GetButtonUp("Jump"))
            Debug.Log("���� ��");
    }
}

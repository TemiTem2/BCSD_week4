using UnityEngine;

public class Testing : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown)
            Debug.Log("Ű �Է�");

        if (Input.anyKey)
            Debug.Log("Ű ������ ��");

        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("���� ����");
        if (Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("���� �Է���");
        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("������ ��");
        
        
        if (Input.GetMouseButtonDown(0))
            Debug.Log("���콺 �Է�");
        if (Input.GetMouseButton(0))
            Debug.Log("���콺 ��������");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("���콺 ��");
    }
}

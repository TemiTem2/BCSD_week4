using UnityEngine;

public class lifecycle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        Debug.Log("������Ʈ�� ���� �ɶ� ���� ����");
    }
    void Start()
    {
        Debug.Log("������Ʈ ���� ���� ���� ����");
    }
    //�ʱ�ȭ
    private void OnEnable()
    {
        Debug.Log("���� ������Ʈ�� Ȱ��ȭ �� �� ����");
    }
    private void FixedUpdate()
    {
        Debug.Log("�������꿡 ���. ������ �����ֱ�� CPU ���� ��� 1�ʿ� 50ȸ");
    }

    //��������
    // Update is called once per frame
    void Update()
    {
        Debug.Log("���������� ������ ���� ����, ��翡 ���� ���� Ƚ���� �ٸ�");
    }

    private void LateUpdate()
    {
        Debug.Log("������Ʈ ���� �ҷ����� ����");
    }
    //����

    private void OnDisable()
    {
        Debug.Log("��Ȱ��ȭ �ɶ� ����");
    }
    private void OnDestroy()
    {
        Debug.Log("������Ʈ ������ ����");
    }
    //��ü
}

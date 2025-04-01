using UnityEngine;

public class lifecycle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        Debug.Log("오브젝트가 생성 될때 최초 실행");
    }
    void Start()
    {
        Debug.Log("업데이트 시작 직전 최초 실행");
    }
    //초기화
    private void OnEnable()
    {
        Debug.Log("게임 오브젝트가 활성화 될 때 실행");
    }
    private void FixedUpdate()
    {
        Debug.Log("물리연산에 사용. 고정된 실행주기로 CPU 많이 사용 1초에 50회");
    }

    //물리연산
    // Update is called once per frame
    void Update()
    {
        Debug.Log("물리로직을 제외한 게임 로직, 사양에 따라 연산 횟수가 다름");
    }

    private void LateUpdate()
    {
        Debug.Log("업데이트 이후 불러오는 로직");
    }
    //로직

    private void OnDisable()
    {
        Debug.Log("비활성화 될때 실행");
    }
    private void OnDestroy()
    {
        Debug.Log("오브젝트 삭제시 실행");
    }
    //해체
}

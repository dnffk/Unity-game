using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //이동 속도
    public float moveSpeed = 7f;
    //캐릭터 컨트롤러 컴포넌트 변수
    CharacterController cc;
    //중력 변수
    float gravity =-20f;
    //수직 속력 변수
    float yVelocity = 0;
    public float jumpPower = 7f;
    
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();//변수를 add component해준다
    }

    // Update is called once per frame
    void Update()
    {
        // 키보드 입력
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //이동 방향 설정
        Vector3 dir = new Vector3(h, 0, v);
        dir = dir.normalized;
        //메인 카메라를 기준으로 방향 전환
        dir = Camera.main.transform.TransformDirection(dir);
        //transform.position += dir * moveSpeed * Time.deltaTime;

        //스페이스바를 입력하면 점프
        if(Input.GetButtonDown("Jump"))
        {
            yVelocity = jumpPower;
        }
        //수직 속도에 중력 값 적용
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;
        //이동
        cc.Move(dir * moveSpeed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    //회전 값 변수(초기화)
    float mx = 0;
    float my = 0;
    //회전 속도 변수(초기화)
    public float rotspeed = 200;
    //캠 포지션 트렌스폼 컴포넌트
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //마우스 입력 값을 받아옴
        float mouse_X = Input.GetAxis("Mouse X");
        float mouse_Y = Input.GetAxis("Mouse Y");

        //회전에는 누적값이 필요하다 마지막으로 변화시킨 시점에서 또 돌려야 하기 때문에
        //회전 값에 마우스 입력 값 누적
        mx += mouse_X * rotspeed * Time.deltaTime;//deltaTime 사용자마다 똑같은 값으로
        my += mouse_Y * rotspeed * Time.deltaTime;
        //세로 각 제한
        my = Mathf.Clamp(my, -90, 90);
        //실제 회전(게임 오브젝트를 회전)
        transform.eulerAngles = new Vector3(-my, mx, 0);
        //mx값은 좌우.좌우로 움직이는 것은 y축 기준

        //카메라 위치를 타겟 트랜스폼에 일치
        transform.position = target.position;

    }
}

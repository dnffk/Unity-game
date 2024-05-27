using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerfire : MonoBehaviour
{
    //피격 이펙트
    public GameObject bulletEffect;
    //피격 이펙트의 파티클 시스템
    ParticleSystem ps;

    // Start is called before the first frame update
    void Start()
    {
        ps = bulletEffect.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        //마우스 왼쪽 버튼을 누르면
        if(Input.GetMouseButtonDown(0))
        {
            //레이 생성
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
            //부딪힌 대상의 정보
            RaycastHit hitInfo = new RaycastHit();

            //레이를 발사한 후 부딪힌 물체가 있다면 이펙트 표시
            if(Physics.Raycast(ray, out hitInfo))
            {
                bulletEffect.transform.position = hitInfo.point;
                ps.Play();
            }
        }
    }
}

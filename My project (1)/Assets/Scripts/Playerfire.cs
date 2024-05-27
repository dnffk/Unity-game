using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerfire : MonoBehaviour
{
    //�ǰ� ����Ʈ
    public GameObject bulletEffect;
    //�ǰ� ����Ʈ�� ��ƼŬ �ý���
    ParticleSystem ps;

    // Start is called before the first frame update
    void Start()
    {
        ps = bulletEffect.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        //���콺 ���� ��ư�� ������
        if(Input.GetMouseButtonDown(0))
        {
            //���� ����
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);
            //�ε��� ����� ����
            RaycastHit hitInfo = new RaycastHit();

            //���̸� �߻��� �� �ε��� ��ü�� �ִٸ� ����Ʈ ǥ��
            if(Physics.Raycast(ray, out hitInfo))
            {
                bulletEffect.transform.position = hitInfo.point;
                ps.Play();
            }
        }
    }
}

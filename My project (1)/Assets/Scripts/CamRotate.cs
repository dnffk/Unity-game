using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    //ȸ�� �� ����(�ʱ�ȭ)
    float mx = 0;
    float my = 0;
    //ȸ�� �ӵ� ����(�ʱ�ȭ)
    public float rotspeed = 200;
    //ķ ������ Ʈ������ ������Ʈ
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //���콺 �Է� ���� �޾ƿ�
        float mouse_X = Input.GetAxis("Mouse X");
        float mouse_Y = Input.GetAxis("Mouse Y");

        //ȸ������ �������� �ʿ��ϴ� ���������� ��ȭ��Ų �������� �� ������ �ϱ� ������
        //ȸ�� ���� ���콺 �Է� �� ����
        mx += mouse_X * rotspeed * Time.deltaTime;//deltaTime ����ڸ��� �Ȱ��� ������
        my += mouse_Y * rotspeed * Time.deltaTime;
        //���� �� ����
        my = Mathf.Clamp(my, -90, 90);
        //���� ȸ��(���� ������Ʈ�� ȸ��)
        transform.eulerAngles = new Vector3(-my, mx, 0);
        //mx���� �¿�.�¿�� �����̴� ���� y�� ����

        //ī�޶� ��ġ�� Ÿ�� Ʈ�������� ��ġ
        transform.position = target.position;

    }
}

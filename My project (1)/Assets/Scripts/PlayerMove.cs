using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //�̵� �ӵ�
    public float moveSpeed = 7f;
    //ĳ���� ��Ʈ�ѷ� ������Ʈ ����
    CharacterController cc;
    //�߷� ����
    float gravity =-20f;
    //���� �ӷ� ����
    float yVelocity = 0;
    public float jumpPower = 7f;
    
    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();//������ add component���ش�
    }

    // Update is called once per frame
    void Update()
    {
        // Ű���� �Է�
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //�̵� ���� ����
        Vector3 dir = new Vector3(h, 0, v);
        dir = dir.normalized;
        //���� ī�޶� �������� ���� ��ȯ
        dir = Camera.main.transform.TransformDirection(dir);
        //transform.position += dir * moveSpeed * Time.deltaTime;

        //�����̽��ٸ� �Է��ϸ� ����
        if(Input.GetButtonDown("Jump"))
        {
            yVelocity = jumpPower;
        }
        //���� �ӵ��� �߷� �� ����
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;
        //�̵�
        cc.Move(dir * moveSpeed * Time.deltaTime);
    }
}

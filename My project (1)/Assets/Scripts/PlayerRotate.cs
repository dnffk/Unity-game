using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    float mx = 0;
    public float rotSpeed = 200f;

    // Update is called once per frame
    void Update()
    {
        //���콺 �Է� ���� �޾ƿ�
        float mouse_X = Input.GetAxis("Mouse X");
        mx += mouse_X * rotSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, mx, 0);
    }
}

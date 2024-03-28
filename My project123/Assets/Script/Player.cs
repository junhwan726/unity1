using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    private bool isTouchRigth;
    private bool isTouchLeft;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed;
    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public void Move()
    {
        // ���� ȭ��ǥ�� ������ ��
        if (Input.GetKey(KeyCode.LeftArrow)&&! isTouchLeft)
        {
            transform.Translate(-speed, 0, 0); // �������� ��3�� �����δ�
        }

        // ������ ȭ��ǥ�� ������ ��
        if (Input.GetKey(KeyCode.RightArrow) &&! isTouchRigth)
        {
            transform.Translate(speed, 0, 0); // ���������� ��3�� �����δ�
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Border")
        {
            switch(collision.gameObject.name)
            {
                case "Right":
                    isTouchRigth = true;
                    break;
                case "Left":
                    isTouchLeft = true;
                    break;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
    }
}


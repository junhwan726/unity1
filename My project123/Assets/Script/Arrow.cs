using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public Transform nextPos;
    // Update is called once per frame
    void Update()
    {
        ArrowDown();
    }
    public void ArrowDown() 
    {
        // �����Ӹ��� ������� ���Ͻ�Ų�� 
        transform.Translate(0, -0.1f, 0);

        // ȭ�� ������ ������ ������Ʈ�� �Ҹ��Ų��
        if (transform.position.y < -5.0f)
        {
            transform.position = nextPos.position;
        }

        // �浹 ����
        Vector2 p1 = transform.position;              // ȭ���� �߽� ��ǥ
        Vector2 p2 = this.player.transform.position;  // �÷��̾��� �߽� ��ǥ
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;  // ȭ���� �ݰ�
        float r2 = 1.0f;  // �÷��̾��� �ݰ�

        if (d < r1 + r2) //r1+r2�� ���� Ŭ���� �־����°� r1+r2 ���� �۾������� ��������°�
        {
            // �浹�� ���� ȭ���� �����
            transform.position = nextPos.position;
        }

    }
}

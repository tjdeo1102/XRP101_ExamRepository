using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotater : MonoBehaviour
{
    // �ð� ������ �޴� FixedUpdate�� ����
    // ť�갡 ������ �ӵ��� ������ ���� �ʰ� ��Ģ������ ȸ��
    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up * GameManager.Intance.Score);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // SetPoint�� �̵��� ��ġ�� �����ؾ������� private�� ���� ���� �Ǿ� ����
    //public Vector3 SetPoint { get; private set; }
    public Vector3 SetPoint { get; set; }

    public void SetPosition()
    {
        transform.position = SetPoint;
    }
}

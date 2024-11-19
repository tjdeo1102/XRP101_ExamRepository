using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    // ������Ƽ �ۼ� ��, get,set���� ���� ������Ƽ�� ȣ���ϸ�
    // ������� ȣ���� �߻��Ͽ�, set�� ���� ��쿡���� MoveSpeed�� value�� �Ҵ��ϱ� ���� �ٽ�, set�� ȣ���ϰ� �Ǵ�
    // ���� �ݺ��� �Ͼ�Ƿ�, float�� �ִ밪�� �ѰԵǸ� �����÷ο찡 �߻��ϰ� �ȴ�.
    private float moveSpeed;
    public float MoveSpeed
    {
        get => moveSpeed;
        private set => moveSpeed = value;
    }
    //public float MoveSpeed
    //{
    //    get => MoveSpeed;
    //    private set => MoveSpeed = value;
    //}

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        MoveSpeed = 5f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    // 프로퍼티 작성 시, get,set에서 본인 프로퍼티를 호출하면
    // 재귀적인 호출이 발생하여, set과 같은 경우에서는 MoveSpeed에 value를 할당하기 위해 다시, set을 호출하게 되는
    // 무한 반복이 일어나므로, float의 최대값을 넘게되며 오버플로우가 발생하게 된다.
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotater : MonoBehaviour
{
    // 시간 영향을 받는 FixedUpdate로 변경
    // 큐브가 프레임 속도에 영향이 가지 않고 규칙적으로 회전
    private void FixedUpdate()
    {
        transform.Rotate(Vector3.up * GameManager.Intance.Score);
    }
}

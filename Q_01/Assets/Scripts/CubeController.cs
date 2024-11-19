using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    // SetPoint로 이동할 위치를 설정해야하지만 private로 접근 제한 되어 있음
    //public Vector3 SetPoint { get; private set; }
    public Vector3 SetPoint { get; set; }

    public void SetPosition()
    {
        transform.position = SetPoint;
    }
}

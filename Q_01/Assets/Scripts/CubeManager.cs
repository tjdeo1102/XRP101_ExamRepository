using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeManager : MonoBehaviour
{
    [SerializeField] private GameObject _cubePrefab;

    private CubeController _cubeController;
    private Vector3 _cubeSetPoint;

    private void Awake()
    {
        // 큐브를 이동시킬 좌표를 사전에 설정
        SetCubePosition(3, 0, 3);
    }

    private void Start()
    {
        CreateCube();
    }

    private void SetCubePosition(float x, float y, float z)
    {
        _cubeSetPoint.x = x;
        _cubeSetPoint.y = y;
        _cubeSetPoint.z = z;
        // 할당되지 않은 _cubeController에서 SetPosition()이 호출됨
        //_cubeController.SetPosition();
    }

    private void CreateCube()
    {
        // 큐브 생성
        GameObject cube = Instantiate(_cubePrefab);
        _cubeController = cube.GetComponent<CubeController>();

        // 사전에 설정한 _cubeSetPoint를 _cubeController.SetPoint에 설정
        //_cubeSetPoint = _cubeController.SetPoint;
        _cubeController.SetPoint = _cubeSetPoint;

        // 인스턴스화된 _cubeController에서 SetPosition()을 호출하여 위치를 이동해야함
        _cubeController.SetPosition();
    }
}

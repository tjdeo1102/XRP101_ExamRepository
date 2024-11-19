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
        // ť�긦 �̵���ų ��ǥ�� ������ ����
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
        // �Ҵ���� ���� _cubeController���� SetPosition()�� ȣ���
        //_cubeController.SetPosition();
    }

    private void CreateCube()
    {
        // ť�� ����
        GameObject cube = Instantiate(_cubePrefab);
        _cubeController = cube.GetComponent<CubeController>();

        // ������ ������ _cubeSetPoint�� _cubeController.SetPoint�� ����
        //_cubeSetPoint = _cubeController.SetPoint;
        _cubeController.SetPoint = _cubeSetPoint;

        // �ν��Ͻ�ȭ�� _cubeController���� SetPosition()�� ȣ���Ͽ� ��ġ�� �̵��ؾ���
        _cubeController.SetPosition();
    }
}

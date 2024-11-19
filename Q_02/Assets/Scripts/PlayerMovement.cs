using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private PlayerStatus _status;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        _status = GetComponent<PlayerStatus>();
    }

    private void Update()
    {
        MovePosition();
    }

    private void MovePosition()
    {
        Vector3 direction = Vector3.zero;
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        if (direction == Vector3.zero) return;
        
        // 대각선 방향에서는 속도가 빨라지는 문제 발생
        // direction의 크기를 모든 방향이 같도록 nomalized를 진행
        transform.Translate(_status.MoveSpeed * Time.deltaTime * direction.normalized);
        //transform.Translate(_status.MoveSpeed * Time.deltaTime * direction);
    }
}

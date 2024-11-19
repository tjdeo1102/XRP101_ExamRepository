using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StateAttack : PlayerState
{
    private float _delay = 2;
    private WaitForSeconds _wait;
    
    public StateAttack(PlayerController controller) : base(controller)
    {
        
    }

    public override void Init()
    {
        _wait = new WaitForSeconds(_delay);
        ThisType = StateType.Attack;
    }

    public override void Enter()
    {
        Controller.StartCoroutine(DelayRoutine(Attack));
    }

    public override void OnUpdate()
    {
        Debug.Log("Attack On Update");
    }

    public override void Exit()
    {
        // 이미 ChangeState에서 해당 Exit를 호출하게 설정되어 있으므로, ChangeState를 Exit에서 호출하면 재귀
        //Machine.ChangeState(StateType.Idle);
    }

    private void Attack()
    {
        Collider[] cols = Physics.OverlapSphere(
            Controller.transform.position,
            Controller.AttackRadius
            );

        IDamagable damagable;

        // 데미지를 입는 몬스터의 TakeHit만 호출하도록 필터링 필요
        foreach (Collider col in cols)
        {
            col.TryGetComponent<IDamagable>(out damagable);
            damagable?.TakeHit(Controller.AttackValue);
        }
        //foreach (Collider col in cols)
        //{
        //    damagable = col.GetComponent<IDamagable>();
        //    damagable.TakeHit(Controller.AttackValue);
        //}
    }

    public IEnumerator DelayRoutine(Action action)
    {
        yield return _wait;

        Attack();
        Machine.ChangeState(StateType.Idle);
        // 이미 ChangeState에서 해당 Exit를 호출하게 설정되어 있으므로, 다시 Exit를 직접 호출할 필요가 없음
        //Exit();
    }

}

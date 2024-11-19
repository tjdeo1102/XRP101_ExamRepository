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
        // �̹� ChangeState���� �ش� Exit�� ȣ���ϰ� �����Ǿ� �����Ƿ�, ChangeState�� Exit���� ȣ���ϸ� ���
        //Machine.ChangeState(StateType.Idle);
    }

    private void Attack()
    {
        Collider[] cols = Physics.OverlapSphere(
            Controller.transform.position,
            Controller.AttackRadius
            );

        IDamagable damagable;

        // �������� �Դ� ������ TakeHit�� ȣ���ϵ��� ���͸� �ʿ�
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
        // �̹� ChangeState���� �ش� Exit�� ȣ���ϰ� �����Ǿ� �����Ƿ�, �ٽ� Exit�� ���� ȣ���� �ʿ䰡 ����
        //Exit();
    }

}

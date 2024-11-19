using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [field: SerializeField]
    [field: Range(0, 100)]
    public int Hp { get; private set; }

    // ���� �Ŵ��� �߰��� ���� ���ʿ��� �ڵ� �ּ� ó��
    //private AudioSource _audio;

    //private void Awake()
    //{
    //    Init();
    //}

    //private void Init()
    //{
    //    _audio = GetComponent<AudioSource>();
    //}
    
    public void TakeHit(int damage)
    {
        Hp -= damage;

        if (Hp <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        // ��Ȱ��ȭ �� �÷��̾�� ���� ��Ʈ���� �ϴ� ���� ����δ��� �ִٰ� �Ǵ�
        // ���带 ������ �ٸ� ������Ʈ���� ���ϴ� ���带 ���
        SoundManager.Audio.Play();
        //_audio.Play();
        gameObject.SetActive(false);
    }
}

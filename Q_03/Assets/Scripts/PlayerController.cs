using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [field: SerializeField]
    [field: Range(0, 100)]
    public int Hp { get; private set; }

    // 사운드 매니저 추가에 의해 불필요한 코드 주석 처리
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
        // 비활성화 될 플레이어에서 사운드 컨트롤을 하는 것은 위험부담이 있다고 판단
        // 사운드를 관리할 다른 오브젝트에서 원하는 사운드를 출력
        SoundManager.Audio.Play();
        //_audio.Play();
        gameObject.SetActive(false);
    }
}

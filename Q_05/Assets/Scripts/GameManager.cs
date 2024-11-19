using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : SingletonBehaviour<GameManager>
{
    public float Score { get; set; }

    private void Awake()
    {
        SingletonInit();
        Score = 0.1f;
    }

    public void Pause()
    {
        Time.timeScale = 0f;
    }

    public void LoadScene(int buildIndex)
    {
        // 씬이 전환될 때, 정상 타임스케일로 초기화
        Time.timeScale = 1f;
        SceneManager.LoadScene(buildIndex);
    }
}

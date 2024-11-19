using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonBehaviour<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;
    public static T Intance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<T>();
                DontDestroyOnLoad(_instance.gameObject);
            }
            return _instance;
        }
    }

    protected void SingletonInit()
    {
        // �̹� ���� �Ŵ����� �����ϴ� ���, ���ο� ���� �Ŵ����� ����
        if (_instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            _instance = GetComponent<T>();
            DontDestroyOnLoad(gameObject);
        }

        //_instance = GetComponent<T>();
        //DontDestroyOnLoad(gameObject);
    }
}

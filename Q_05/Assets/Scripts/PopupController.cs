using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupController : MonoBehaviour
{
    [SerializeField] private float _deactiveTime;
    // timescale의 영향을 받지 않는 WaitForSecondsRealtime으로 의도한 기능 수행
    private WaitForSecondsRealtime _wait;
    //private WaitForSeconds _wait;

    private Button _popupButton;

    [SerializeField] private GameObject _popup;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        _wait = new WaitForSecondsRealtime(_deactiveTime);
        _popupButton = GetComponent<Button>();
        SubscribeEvent();
    }

    private void SubscribeEvent()
    {
        _popupButton.onClick.AddListener(Activate);
    }

    private void Activate()
    {
        _popup.gameObject.SetActive(true);
        GameManager.Intance.Pause();
        StartCoroutine(DeactivateRoutine());
    }

    private void Deactivate()
    {
        // 팝업이 닫힐 때, timescale 정상화
        Time.timeScale = 1f;
        _popup.gameObject.SetActive(false);
    }

    private IEnumerator DeactivateRoutine()
    {
        yield return _wait;
        Deactivate();
    }
}

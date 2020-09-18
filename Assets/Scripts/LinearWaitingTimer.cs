using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LinearWaitingTimer : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 5f;
    public float fillingSpeed = 10f;
    float timeLeft;
    public GameObject timerText;
    public GameObject imgResult;
    private Action onComplete;
    
    public void Init(Action callback) 
    {

        if (timeLeft <= 0)
        {
            onComplete = callback;
            timerBar = GetComponent<Image>();
            timeLeft = maxTime;
            timerText.SetActive(true);
            imgResult.SetActive(false);
        }
    }

    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime*fillingSpeed;
            timerBar.fillAmount = timeLeft / maxTime;

        }
        else 
        {
            timerText.SetActive(false);
            imgResult.SetActive(true);
            onComplete?.Invoke();
        }
    }
}

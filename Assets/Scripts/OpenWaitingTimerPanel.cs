using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenWaitingTimerPanel : MonoBehaviour
{
    public GameObject Panel;

    public void OpenPanel() 
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
            var WaitingTimer = Panel.GetComponentInChildren<LinearWaitingTimer>();
            if(WaitingTimer != null)
            { 
                WaitingTimer.Init(HidePanel); 
            }
        }
    }

    public void HidePanel()
    {
        Panel.SetActive(false);
    }
}

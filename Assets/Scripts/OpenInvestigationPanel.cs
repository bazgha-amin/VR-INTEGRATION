using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenInvestigationPanel : MonoBehaviour
{
   public GameObject Panel;

   public void InvestigationPanel()
   {
       if (Panel != null)
       {
           bool isActive = Panel.activeSelf;
           Panel.SetActive (!isActive);
       }
   }
}

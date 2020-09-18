using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class QuestionButton : MonoBehaviour
{
    [HideInInspector]
    public QuestionsUI questionsUI;
    public Text questionText;
    [HideInInspector]
    public int index;
    public void OnButtonClick() 
    {
        questionsUI.OnButtonEvent(index);
    }
}

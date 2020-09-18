using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/VPSDataScriptableObject", order = 1)]
public class VPSDATA : ScriptableObject
{

    public List<VPSQuestion> questions;


}

[System.Serializable]
public class VPSQuestion
{
    public string question;
    public AudioClip answer;
    public bool isCorrect;
}
[System.Serializable]
public class VPSProgress
{

    public List<QsProgress> progress;
    public VPSProgress()
    {
        progress = new List<QsProgress>();
    }
    public int Marks()
    {
        int sum = 0;
        for (int i = 0; i < progress.Count; i++)
        {
            sum = sum + progress[i].marks;
        }
        return sum;
    }
}
[System.Serializable]
public class QsProgress
{
    public int questionId;
    public bool attemptStatus;
    public int marks;
}
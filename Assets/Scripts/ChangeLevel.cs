using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevel : MonoBehaviour
{
    public void changescene(string sceneName) 
    {
        Application.LoadLevel (sceneName);
    }
}

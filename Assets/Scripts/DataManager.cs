using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public VPSDATA vps;
    public VPSQuestion GetData(int index) 
    {
        return vps.questions[index];
    }

    
}

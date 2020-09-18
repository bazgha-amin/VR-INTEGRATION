using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Temperature : MonoBehaviour
{
    public GameObject TextBox; 
    float number;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextBox.GetComponent<Text>().text="TEMPERATURE = " + AppConfig.sharedInstance().temperature + " °C";
    }
    public void RandomNumber(){
        number = Random.Range (101f,105f);

    }
}

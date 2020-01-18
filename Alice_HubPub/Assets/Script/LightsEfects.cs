using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsEfects : MonoBehaviour
{
    //public Light Light;
    public bool isLightOff;
    public GameObject gameObject;
   // public bool isEmissionOn;
    void Start()
    {
        
    }
    void TurnLight()
    {
        if (!isLightOff)
        {
            //Light.enabled = true;
            gameObject.SetActive(true);
        }
        else
        {
            //Light.enabled = false;
            gameObject.SetActive(false);
        }
    }
    /*
    void TurnEmission()
    {
        if (isLightOn)
            Light.enabled = true;
        else
            Light.enabled = false;
    }*/
   
}

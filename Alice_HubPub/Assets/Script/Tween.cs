using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tween : MonoBehaviour
{
    public iTween.EaseType easeType;
    public iTween.LoopType loopType;
    public int number=5;
    public float numberTwo = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        iTween.RotateTo(this.gameObject, iTween.Hash("x", number, "easyType", easeType, "time", numberTwo, "loopType", loopType));
    }
}

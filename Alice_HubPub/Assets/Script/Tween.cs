using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tween : MonoBehaviour
{
    public iTween.EaseType easeType;
    public iTween.LoopType loopType;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        iTween.RotateTo(this.gameObject, iTween.Hash("x", 5, "easyType", easeType, "time", 0.5f, "loopType", loopType));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getSmaller : MonoBehaviour
{
    [SerializeField] Transform transformObiekt;
    Collider spherCol;
    public bool isOn = false;
    public float ile = 0.0f;
    private void Start()
    {
        spherCol = GetComponent<SphereCollider>();
    }

    private void FixedUpdate()
    {
        if(isOn == true && ile < 0.6f)
        {
            transformObiekt.transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
            ile += 0.01f;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            isOn = true;
            Destroy(spherCol);
            
        }
    }
}

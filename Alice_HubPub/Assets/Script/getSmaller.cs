using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getSmaller : MonoBehaviour
{
    [SerializeField] Transform transformObiekt;
    [SerializeField] float speed = 2.0f;
    [SerializeField] float moveSpeed = 2.0f;
    Collider spherCol;
    public bool isOn = false;
    public float ile = 0.0f;
    float positionY;
    private void Start()
    {
        spherCol = GetComponent<SphereCollider>();
        float positionY = transformObiekt.position.y;
    }

    private void FixedUpdate()
    {
        if(isOn == true && ile < 0.6f)
        {

            transformObiekt.transform.localScale -= new Vector3(0.1f, 0.0f, 0.1f) * Time.deltaTime * speed;
            
            ile += 0.01f;
        }

        if(positionY >= 0.13f)
        {
            transformObiekt.transform.localPosition -= new Vector3(0.0f, 0.03f, 0.0f) * Time.deltaTime * moveSpeed;
            
        }
        positionY = transformObiekt.position.y;
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

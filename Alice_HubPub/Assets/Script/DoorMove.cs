using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMove : MonoBehaviour
{
   public Animator animator;
    private bool status = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        status = true;
    }

    public void OnTriggerExit(Collider other)
    {
        status = false;
    }

    private void OnMouseOver()
    {
        if(status == true && Input.GetMouseButton(0))
        {
            animator.Play("Door_open");
        }
    }

}

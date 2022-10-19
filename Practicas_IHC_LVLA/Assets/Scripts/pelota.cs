using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pelota : Interactable
{
    private Rigidbody rb;
    public Vector3 direction;
    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    public override void Interact(){
        base.Interact();
        rb.AddForce(direction*speed, ForceMode.Force);
    }
}

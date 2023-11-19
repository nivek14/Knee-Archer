using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour{

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float arrowSpeed;

    void Start(){
        Movement();
    }

    private void Movement(){
        rb.velocity = transform.position * arrowSpeed;
    }

}

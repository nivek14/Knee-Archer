using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour{

    private Rigidbody2D rb;
    private bool hasHit;
    
    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        if(hasHit == false){
            // fazendo a flecha rotacionar corretamente após colidir com algo
            float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

    // colidindo com o chão iremos manter a posição da flecha em 0, assim ela se mantém parada
    private void OnCollisionEnter2D(Collision2D other) {
        hasHit = true;
        rb.velocity = Vector2.zero;
        rb.isKinematic = true;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BaseTarget : MonoBehaviour {

    public int hitToDestroy;

    private void Start() {
        hitToDestroy = 1;
    }

    void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Arrow"){
            TargetDamage();
        }
    }

    private void TargetDamage(){
        hitToDestroy -= 1;
        if(hitToDestroy == 0) Destroy(gameObject);
    }

}

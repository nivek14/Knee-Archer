using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBow : MonoBehaviour{

    public Transform gunHolder;
    public float yPivot;
 
    void Update(){
        BowMovement();
    }

    void BowMovement(){
        // inputs do mouse
        Vector3 mousePos = Input.mousePosition;
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.localPosition);
        // rotação do arco
        Vector2 offset = new Vector2(mousePos.x - screenPoint.x, -yPivot);
        float angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;
        angle = Mathf.Clamp(angle, -180, 0);
        gunHolder.rotation = Quaternion.Euler(0,0,angle);
        Debug.Log(angle);
    }
    
}

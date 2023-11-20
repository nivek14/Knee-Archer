using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBow : MonoBehaviour{

    public Transform gunHolder;
    public float yPivot;
 
    void Update(){
        BowMovement180();
        //BowMovement360();
    }

    void BowMovement180(){
        // inputs do mouse
        Vector3 mousePos = Input.mousePosition;
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.localPosition);
        // rotação do arco
        Vector2 offset = new Vector2(mousePos.x - screenPoint.x, -yPivot);
        float angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;
        angle = Mathf.Clamp(angle, -180, 0);
        gunHolder.rotation = Quaternion.Euler(0,0,angle); 
    }

    void BowMovement360(){
        // inputs do mouse
        Vector3 mousePos = Input.mousePosition;
        Vector3 screenPoint = Camera.main.WorldToScreenPoint(transform.localPosition);
        // rotação do arco
        Vector2 offset = new Vector2(mousePos.x - screenPoint.x, mousePos.y - screenPoint.y);
        float angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;
        gunHolder.rotation = Quaternion.Euler(0,0,angle);
    }
    
}

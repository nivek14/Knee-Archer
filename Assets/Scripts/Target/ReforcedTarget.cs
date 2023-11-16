using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReforcedTarget: BaseTarget{

    [SerializeField] private float speedX;
    [SerializeField] private float speedY;

    public int changeDirection;

    private int movmentType;

    void Start() {
        // 0 = left / up || 1 = right / down
        changeDirection = Random.Range(0, 2);
        // 0 = vertical || 1 = horizontal
        movmentType = Random.Range(0,2);
        hitToDestroy = 2;
    }

    void Update() {
        if(movmentType == 0) MoveVertically(); 
        else MoveHorizontally();
    }

    private void MoveHorizontally(){
        if(changeDirection == 0) transform.Translate(Vector2.left * speedX * Time.deltaTime);
        else transform.Translate(Vector2.right * speedX * Time.deltaTime);
     }

    private void MoveVertically(){
        if(changeDirection == 0) transform.Translate(Vector2.up * speedY * Time.deltaTime);
        else transform.Translate(Vector2.down * speedY * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.transform.tag == "LeftWall" || other.gameObject.transform.tag == "UpWall") changeDirection = 1;
        else if(other.gameObject.transform.tag == "RightWall" || other.gameObject.transform.tag == "DownWall") changeDirection = 0;
    }

}
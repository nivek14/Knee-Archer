using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalTarget: BaseTarget{

     [SerializeField] private float speedY;
     private int changeDirection;

     void Start() {
          // 0 = up
          // 1 = down
          changeDirection = Random.Range(0, 2);
     }

     void Update() {
          MoveVertically(); 
     }

     private void MoveVertically(){
          if(changeDirection == 0) transform.Translate(Vector2.up * speedY * Time.deltaTime);
          else transform.Translate(Vector2.down * speedY * Time.deltaTime);
     }

     private void OnTriggerEnter2D(Collider2D other) {
          if(other.gameObject.transform.tag == "UpWall") changeDirection = 1;
          else if(other.gameObject.transform.tag == "DownWall") changeDirection = 0;
     }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalTarget: BaseTarget{

     [SerializeField] private float speedX;

     private int changeDirection;

     void Start() {
          // 0 = left
          // 1 = right
          changeDirection = Random.Range(0, 2);
     }

     void Update() {
          MoveHorizontally(); 
     }

     private void MoveHorizontally(){
          if(changeDirection == 0) transform.Translate(Vector2.left * speedX * Time.deltaTime);
          else transform.Translate(Vector2.right * speedX * Time.deltaTime);
     }

     private void OnTriggerEnter2D(Collider2D other) {
          if(other.gameObject.transform.tag == "LeftWall") changeDirection = 1;
          else if(other.gameObject.transform.tag == "RightWall") changeDirection = 0;
     }

}
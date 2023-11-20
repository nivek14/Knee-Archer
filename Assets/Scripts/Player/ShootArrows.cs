using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootArrows : MonoBehaviour{

    [SerializeField] private GameObject arrow;
    [SerializeField] private Transform arrowPoint;
    [SerializeField] private float launchForce;

    void Update(){
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }

    private void Shoot(){
        GameObject newArrow = Instantiate(arrow, arrowPoint.position, arrowPoint.rotation);
        newArrow.GetComponent<Rigidbody2D>().velocity = transform.position * launchForce;
    }

}

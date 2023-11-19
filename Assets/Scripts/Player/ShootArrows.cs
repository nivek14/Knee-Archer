using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootArrows : MonoBehaviour{

    [SerializeField] private GameObject arrow;
    [SerializeField] private Transform arrowPoint;

    void Update(){
        if(Input.GetButtonDown("Fire1")){
            Shoot();
        }
    }

    private void Shoot(){
        Instantiate(arrow, arrowPoint.position, arrowPoint.rotation);
    }

}

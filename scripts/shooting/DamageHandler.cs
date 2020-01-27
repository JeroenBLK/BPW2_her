using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour {

    int health = 1;
    public GameObject bulletPrefab;




    void OnTriggerEnter2D() {
        Debug.Log ("Trigger!");

        health-- ;

        if(health <= 0) {
            Die();
        }
    }

    void Die() {
        Destroy(bulletPrefab);
    }

}

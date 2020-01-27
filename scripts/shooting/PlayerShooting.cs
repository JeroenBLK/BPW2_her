using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;

    public float fireDelay = 0.25f;
    float cooldowntimer = 0;

    void Update() {
        cooldowntimer -= Time.deltaTime;

        if( Input.GetButton("Fire1") && cooldowntimer <= 0) {
            Debug.Log("BRRAAA");
            cooldowntimer = fireDelay;

            Vector3 offset = transform.rotation * new Vector3(0, 2f, 0);

            Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
        }
    }
}

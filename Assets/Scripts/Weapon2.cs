using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon2 : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint2;



    // Update is called once per frame
    void Update()
        {
            if (Input.GetButtonDown("Fire1"))
                {
                    Shoot();
                }
        }
    void Shoot ()
        {
            Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
            
        }
}

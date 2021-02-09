using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponScript : MonoBehaviour
{
    int totalWeapons = 1;
    public int currentWeaponIndex;
    public GameObject bulletPrefab;
    public GameObject laser;
    public GameObject swordAttack;
    public Transform firePoint2;
    public Transform firePoint;
    public Transform impact;
    public GameObject[] guns;
    public GameObject weaponHolder;
    public GameObject currentGun;

    // Start is called before the first frame update
    void Start()
    {
        totalWeapons = weaponHolder.transform.childCount;
        guns = new GameObject[totalWeapons];

        for (int i = 0; i < totalWeapons; i++)
        {
            guns[i] = weaponHolder.transform.GetChild(i).gameObject;
            guns[i].SetActive(false);
        }

        guns[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Z))
        {
            guns[currentWeaponIndex].SetActive(false);
            currentWeaponIndex = 0;
            guns[currentWeaponIndex].SetActive(true);
            currentGun = guns[currentWeaponIndex]; 
        }

        if(Input.GetKeyDown(KeyCode.X))
        {
            guns[currentWeaponIndex].SetActive(false);
            currentWeaponIndex = 1;
            guns[currentWeaponIndex].SetActive(true);
            currentGun = guns[currentWeaponIndex]; 
        }

        if(Input.GetKeyDown(KeyCode.C))
        {
            guns[currentWeaponIndex].SetActive(false);
            currentWeaponIndex = 2;
            guns[currentWeaponIndex].SetActive(true);
            currentGun = guns[currentWeaponIndex]; 
        }

        if (currentWeaponIndex == 0){
            if (Input.GetKeyDown(KeyCode.Z)){
                Instantiate(bulletPrefab, firePoint2.position, firePoint2.rotation);
            }
        }

        if (currentWeaponIndex == 1){
            if (Input.GetKeyDown(KeyCode.X)){
                Instantiate(swordAttack, impact.position, impact.rotation);
            }
        }

        if (currentWeaponIndex == 2){
            if (Input.GetKeyDown(KeyCode.C)){
                Instantiate(laser, firePoint.position, firePoint.rotation);
            }
        }
    }
}

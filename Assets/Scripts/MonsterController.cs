using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MonsterController : MonoBehaviour
{

    public Vector3 FinalDestination;
    public int health;
    public float movementSpeed;

    void Update()
        {
            transform.Translate(new Vector3(movementSpeed * -1, 0, 0));
        }

}


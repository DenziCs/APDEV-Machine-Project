using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetection : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemyBullet")
        {

        }

        else if (other.tag == "enemyShip")
        {

        }
    }
}

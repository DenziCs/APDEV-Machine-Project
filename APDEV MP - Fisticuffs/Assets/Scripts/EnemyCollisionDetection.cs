using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollisionDetection : MonoBehaviour
{
    [SerializeField] private EnemySpawnBehavior spawnBehavior;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerBullet")
        {
            spawnBehavior.DespawnEnemy(this.gameObject);
        }
    }
}

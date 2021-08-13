using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [SerializeField] private float speed;

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = this.gameObject.transform.position;
        currentPosition.y -= speed * Time.deltaTime;
        this.gameObject.transform.position = currentPosition;
    }
}
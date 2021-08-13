using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehavior : MonoBehaviour
{
    [SerializeField] private float speed;
    private float endPositionY = 3.05f;
    private bool isDescending = true;

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.activeSelf)
        {
            if (isDescending)
            {
                Vector3 currentPosition = this.gameObject.transform.position;
                currentPosition.y -= this.speed * Time.deltaTime;
                if (currentPosition.y <= endPositionY)
                {
                    currentPosition.y = this.endPositionY;
                    this.isDescending = false;
                }

                this.gameObject.transform.position = currentPosition;
            }
        }
    }
}
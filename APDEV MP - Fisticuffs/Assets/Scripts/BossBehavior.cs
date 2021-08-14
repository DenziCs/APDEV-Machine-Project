using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBehavior : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Camera mainCam;
    private float endPositionY;
    private bool isDescending = true;

    void Start()
    {
        Vector3 endPosition = this.mainCam.ViewportToWorldPoint(new Vector3(0f, 0.8f, 0f));
        this.endPositionY = endPosition.y;
    }

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

            else
            {

            }
        }
    }
}
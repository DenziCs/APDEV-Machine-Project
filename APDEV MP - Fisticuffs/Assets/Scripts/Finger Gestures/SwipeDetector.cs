using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SwipeDetector : MonoBehaviour
{
    private Vector2 fingerDownPos;
    private Vector2 fingerUpPos;

    [SerializeField] private float minDistanceForSwipe = 20f;

    public static event Action<SwipeDetector> OnSwipe = delegate { };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Touch touch in Input.touches)
        {

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitch : MonoBehaviour
{
    public SwipeDetector swipeControls;
    public int weaponType = 0;

    // Update is called once per frame
    void Update()
    {
        if (swipeControls.swipeLeft)
        {
            weaponType--;
            if (weaponType == -1)
            {
                weaponType = 2;
            }
        }
        if (swipeControls.swipeRight)
        {
            weaponType++;
            if (weaponType == 3)
            {
                weaponType = 0;
            }
        }
    }
}

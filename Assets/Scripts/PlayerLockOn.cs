using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLockOn : MonoBehaviour
{
    // Target Enemy Reference
    public GameObject target;

    public bool isLockedOn = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("tab") && !isLockedOn)
        {
            isLockedOn = true;
            print("Locked On!");
            target.GetComponent<EnemyLockOn>().drawLockOn = true;

        } else if (Input.GetKeyDown("tab") && isLockedOn)
        {
            isLockedOn = false;
            print("Not Locked On!");
            target.GetComponent<EnemyLockOn>().drawLockOn = false;

        }
    }
}

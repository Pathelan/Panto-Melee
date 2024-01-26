using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLockOn : MonoBehaviour
{
    [SerializeField] private GameObject lockOn;

    public bool drawLockOn = false;

    // Update is called once per frame
    void Update()
    {
        lockOn.SetActive(drawLockOn); 
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLockOn : MonoBehaviour
{
    [SerializeField] private MeshRenderer renderer;

    public bool drawLockOn = false;

    // Update is called once per frame
    void Update()
    {
        renderer.enabled = drawLockOn;
    }
}

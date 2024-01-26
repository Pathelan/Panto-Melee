using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerThrowTomato : MonoBehaviour
{
    [SerializeField] private GameObject tomato;
    [SerializeField] private Transform spawnPoint;

    public int tomatoesHeld = 0;

    private void Awake()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && tomatoesHeld > 0)
        {
            // Spawn Tomato
            GameObject projectile = Instantiate(tomato, spawnPoint.position, transform.rotation);
            projectile.GetComponent<TomatoScript>().owner = this.gameObject;

            // Reduce Tomato Count
            tomatoesHeld--;
        }
    }
}

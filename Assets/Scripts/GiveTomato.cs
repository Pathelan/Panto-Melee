using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveTomato : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // Increase Player's Tomato Count
            other.GetComponent<PlayerThrowTomato>().tomatoesHeld += 1;
            GameObject.Destroy(gameObject);
        }
    }
}

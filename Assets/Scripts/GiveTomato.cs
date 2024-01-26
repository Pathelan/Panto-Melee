using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveTomato : MonoBehaviour
{
    [SerializeField] private GameObject sound;

    [SerializeField] private AudioClip audienceBoo;
    [SerializeField] private AudioClip audienceGasp;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            // Sounds
            GameObject sfx = Instantiate(sound, transform.position, transform.rotation);
            sfx.GetComponent<AudioSource>().clip = audienceGasp;

            // Increase Player's Tomato Count
            other.GetComponent<PlayerThrowTomato>().tomatoesHeld += 1;
            GameObject.Destroy(gameObject);
        }
        
        if (other.tag == "Enemy")
        {
            // Sounds
            GameObject sfx = Instantiate(sound, transform.position, transform.rotation);
            sfx.GetComponent<AudioSource>().clip = audienceBoo;
            print("Should play sound");

            // Increase Enemy's Tomato Count
            //other.GetComponent<PlayerThrowTomato>().tomatoesHeld += 1;
            GameObject.Destroy(gameObject);
        }
    }
}

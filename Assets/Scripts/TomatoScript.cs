using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoScript : MonoBehaviour
{
    public GameObject owner;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip splat;


    public float hSpeed = 6f;
    public float vSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ground")
        {
            // Destroy
            audioSource.clip = splat;
            audioSource.Play();
            GameObject.Destroy(gameObject);
        }

        if (other.tag == "Player" && owner.tag != "Player")
        {
            // Stun Player
            audioSource.clip = splat;
            audioSource.Play();

            GameObject.Destroy(gameObject);
        }
        
        if (other.tag == "Enemy" && owner.tag != "Enemy")
        {
            // Stun Enemy
            audioSource.clip = splat;
            audioSource.Play();

            GameObject.Destroy(gameObject);
        }
    }
}

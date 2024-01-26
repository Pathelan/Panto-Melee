using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoScript : MonoBehaviour
{
    public GameObject owner;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip splat;

    [SerializeField] private Rigidbody rb;


    [SerializeField] private AudioClip ooh1;
    [SerializeField] private AudioClip ooh2;
    [SerializeField] private AudioClip ooh3;
    [SerializeField] private AudioClip ooh4;
    private AudioClip[] audienceOohs;
    
    [SerializeField] private AudioClip laugh1;
    [SerializeField] private AudioClip laugh2;
    [SerializeField] private AudioClip laugh3;
    private AudioClip[] audienceLaughs;


    public float launchForce = 15f;
    public float launchHeight = 0f;


    private MeshRenderer renderer;
    private SphereCollider sphereCollider;

    private void Awake()
    {
        // Set Up Sounds
        audienceOohs = new AudioClip[4];
        audienceLaughs = new AudioClip[3];

        audienceOohs[0] = ooh1;
        audienceOohs[1] = ooh2;
        audienceOohs[2] = ooh3;
        audienceOohs[3] = ooh4;

        audienceLaughs[0] = laugh1;
        audienceLaughs[1] = laugh2;
        audienceLaughs[2] = laugh3;
    }



    // Start is called before the first frame update
    void Start()
    {
        // Get Assets
        renderer = GetComponent<MeshRenderer>();
        sphereCollider = GetComponent<SphereCollider>();
        rb = GetComponent<Rigidbody>();

        // Apply Force
        rb.velocity = transform.right * launchForce;
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator AudienceOoh()
    {
        audioSource.clip = splat;
        audioSource.volume = 0.2f;
        audioSource.Play();

        yield return new WaitForSeconds(0.5f);

        int chosenSound = Random.Range(0, audienceOohs.Length);
        AudioClip clip = audienceOohs[chosenSound];
        audioSource.volume = 0.25f;
        audioSource.PlayOneShot(clip);
        print(chosenSound.ToString());

        yield return new WaitForSeconds(7.5f);

        GameObject.Destroy(gameObject);
    }
    
    IEnumerator AudienceLaugh()
    {
        audioSource.clip = splat;
        audioSource.volume = 0.2f;
        audioSource.Play();

        yield return new WaitForSeconds(0.5f);

        int chosenSound = Random.Range(0, audienceLaughs.Length);
        AudioClip clip = audienceLaughs[chosenSound];
        audioSource.volume = 0.25f;
        audioSource.PlayOneShot(clip);
        print(chosenSound.ToString());

        yield return new WaitForSeconds(7.5f);

        GameObject.Destroy(gameObject);
    }

    IEnumerator HitGround()
    {
        audioSource.clip = splat;
        audioSource.volume = 0.2f;
        audioSource.Play();

        yield return new WaitForSeconds(1f);

        GameObject.Destroy(gameObject);
    }

    private void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Player" && owner.tag != "Player")
        {
            // Stun Player
            StartCoroutine(AudienceOoh());

            renderer.enabled = false;
            sphereCollider.enabled = false;
        }
        
        if (other.tag == "Enemy" && owner.tag != "Enemy")
        {
            // Stun Enemy
            StartCoroutine(AudienceLaugh());

            renderer.enabled = false;
            sphereCollider.enabled = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            // Hit Ground
            StartCoroutine(HitGround());

            renderer.enabled = false;
            sphereCollider.enabled = false;
        }
    }
}

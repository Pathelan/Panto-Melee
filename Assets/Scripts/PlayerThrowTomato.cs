using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerThrowTomato : MonoBehaviour
{
    [SerializeField] private GameObject tomato;
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private TextMeshProUGUI text;

    private Animator anim;

    public int tomatoesHeld = 0;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && tomatoesHeld > 0)
        {
            // Spawn Tomato
            anim.Play("p_Throw");
            gameObject.GetComponent<ThirdPersonMovement>().canMove = false;
        }
    }

    void ThrowTomato()
    {
        GameObject projectile = Instantiate(tomato, spawnPoint.position, transform.rotation);
        projectile.GetComponent<TomatoScript>().owner = this.gameObject;

        // Reduce Tomato Count
        tomatoesHeld--;
        text.GetComponent<TextMeshProUGUI>().text = tomatoesHeld.ToString();
    }
}

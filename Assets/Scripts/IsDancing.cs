using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsDancing : MonoBehaviour
{
    [SerializeField] private Animator anim;
    [SerializeField] private bool isDancing;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        anim.SetBool("isDancing", isDancing);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

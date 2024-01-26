using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaughOMeterScript : MonoBehaviour
{
    public Slider laughOMeter;
    public float playerScore=500;
    public float enemyScore=500;
    public float maxSize;
    public float currentFillPercentage;

    // Start is called before the first frame update
    void Start()
    {
        maxSize = playerScore + enemyScore;
    }

    // Update is called once per frame
    void Update()
    {
        maxSize = playerScore + enemyScore;
        currentFillPercentage = (playerScore / maxSize)*100;

        if(laughOMeter.value!=currentFillPercentage)
        {
            laughOMeter.value = currentFillPercentage;
        }
    }
}

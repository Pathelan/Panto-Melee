using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TomatoTextScript : MonoBehaviour
{
    public TextMeshProUGUI textMesh;
    [SerializeField] private GameObject player;

    // Update is called once per frame
    void Update()
    {
        GetComponent<TextMeshProUGUI>().text = player.GetComponent<PlayerThrowTomato>().tomatoesHeld.ToString() + "x";
    }
}

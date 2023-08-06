using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ss : MonoBehaviour
{
    public TextMeshProUGUI sss;
    // Start is called before the first frame update
    void Start()
    {
        sss.text =player.score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        sss.text = "score: " + player.score.ToString();

    }
}

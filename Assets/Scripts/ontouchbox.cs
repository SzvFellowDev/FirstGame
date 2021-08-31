using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ontouchbox : MonoBehaviour
{
    public Text textscore;
    private int score = 0;

    void updateScore()
    {
        score++;
        textscore.text = "Punkty: " + score;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Bomb")
        {
            updateScore();
            target.gameObject.SetActive(false);
        }    
    }
}

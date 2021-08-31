using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    public float speed = 6f;
    private float minX = -2.55f;
    private float maxX = 2.55f;
    
    void Start()
    {
        Time.timeScale = 1f;
    }
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        float a = Input.GetAxisRaw("Horizontal");
        Vector2 currentposition = transform.position;
        if(a > 0)
        {
            currentposition.x += speed * Time.deltaTime;
        } else if (a < 0)
        {
            currentposition.x -= speed * Time.deltaTime;
        }

        if(currentposition.x > maxX)
        {
            currentposition.x = maxX;
        }
        if(currentposition.x < minX)
        {
            currentposition.x = minX;
        }
        transform.position = currentposition;
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bomb")
        {
            Time.timeScale = 0f;
            StartCoroutine(newgame());
        }
    }

    IEnumerator newgame()
    {
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene("SampleScene");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float Force;
    Rigidbody2D rb;
    public GameObject gameover,player;
    // Start is called before the first frame update
    void Start()
    {
        gameover.SetActive(false);
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Force += Time.deltaTime * 0.01f;
        if (Input.GetKey(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * Force;
        }
        transform.position += new Vector3(Time.deltaTime * 2, 0, 0);

        if (transform.position.y <= -5.65f)
        {
            Time.timeScale = 0;
            gameover.SetActive(true);
        }

        if (transform.position.y >= 5.65f)
        {
            Time.timeScale = 0;
            gameover.SetActive(true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "pipe")
        {
            Time.timeScale = 0;
            gameover.SetActive(true);
        }
    }
    public void Restart()
    {
        player.SetActive(true);
        gameover.SetActive(false);
        SceneManager.LoadScene("Fllapy bird");
        
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;


public class Frog : MonoBehaviour
{
    public Rigidbody2D rb;
    public AudioSource deathSound;
    public bool flag;
    void Start()
    {
        flag = false;
    }
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.MovePosition(rb.position + Vector2.right);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.MovePosition(rb.position + Vector2.left);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.MovePosition(rb.position + Vector2.up);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.MovePosition(rb.position + Vector2.down);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!flag)
            {
                flag = true;
                Time.timeScale = 0;
            }
            else
            {
                flag = false;
                Time.timeScale = 1;
            }
        }

    }

    void OnTriggerEnter2D (Collider2D col)
    {
        if (col.tag =="Car")
        {
            deathSound.Play();
            Invoke("gameOver", .3f);
        }
    }

    void gameOver()
    {
        SceneManager.LoadScene("Exit");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D rb;
    private string axis;
    private bool isJump = false;
    private string player;
    private GameObject pObj;
    private float initialY;
    private int life = 3;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        switch (this.gameObject.name)
        {
            case "Ball2":
                axis = "Fire1";
                player = "Player2";
                break;
            case "Ball1":
                axis = "Jump";
                player = "Player1";
                break;
        }
        initialY = transform.position.y;
    }
    // Start is called before the first frame update
    void Start()
    {
        pObj = GameObject.Find(player);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw(axis) != 0 && !isJump)
        {
            Vector2 vector = Vector2.zero;
            vector.x = Random.Range(-1, 1.1f);
            vector.y = -1;
            rb.AddForce(vector.normalized * 200);
            isJump = true; 
        } else if(!isJump)
        {
            transform.position = new Vector2(pObj.transform.position.x,transform.position.y);
        }

        if(transform.position.y < -5.5f)
        {
            life--;
            if (life <= 0)
            {
                switch (this.gameObject.name)
                {
                    case "Ball2":
                       Destroy(GameObject.Find("Player2"));
                        break;
                    case "Ball1":
                        Destroy(GameObject.Find("Player1"));
                        break;
                }
                if(GameObject.Find("Player2") == null && GameObject.Find("Player1") == null)
                {
                    Application.LoadLevel(Application.loadedLevel);
                }
            }
            else
            {
                isJump = false;
                rb.velocity = Vector2.zero;
                transform.position = new Vector2(pObj.transform.position.x, initialY);
            }
        }
    }
}

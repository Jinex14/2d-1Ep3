using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Capsule : MonoBehaviour
{
    private Text p1, p2;
    // Start is called before the first frame update
    void Start()
    {
        p1 = GameObject.Find("TextP1").GetComponent<Text>();
        p2 = GameObject.Find("TextP2").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5.5f)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player2")
        {
            print("Entro");
            int p2Points = int.Parse(p2.text);
            p2.text = $"{p2Points + 1}";
        }
        if (collision.gameObject.name == "Player1")
        {
            int p1Points = int.Parse(p1.text);
            p1.text = $"{p1Points + 1}";
        }
        Destroy(gameObject);
    }
}

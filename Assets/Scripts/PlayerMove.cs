using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private float limitL, limitR;
    private Rigidbody2D rb;
    private string axis;
    private float axisX;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        switch (this.gameObject.name)
        {
            case "Player1": 
                axis = "p2"; 
                break;
            case "Player2":
                axis = "p1";
                break;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        axisX = Input.GetAxisRaw(axis);
        rb.velocity = new Vector2(axisX * speed, rb.velocity.y);
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, limitL, limitR), -4.4f);
    }


}

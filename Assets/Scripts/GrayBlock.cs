using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrayBlock : MonoBehaviour
{
    [SerializeField] private GameObject prefab1, prefab2;
    private int life = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        life--;
        if(life <= 0)
        {
            if (collision.gameObject.name == "Ball1")
            {
                Instantiate(prefab1, transform.position, Quaternion.identity);
            }
            if (collision.gameObject.name == "Ball2")
            {
                Instantiate(prefab2, transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
    }
}

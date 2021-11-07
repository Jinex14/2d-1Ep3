using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Transform gray;
    public Transform white;
    private Text p1, p2,win;
    // Start is called before the first frame update
    void Start()
    {
        p1 = GameObject.Find("TextP1").GetComponent<Text>();
        p2 = GameObject.Find("TextP2").GetComponent<Text>();
        win = GameObject.Find("Ganado").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(white.childCount == 0 && gray.childCount == 0)
        {
            int p2Points = int.Parse(p2.text);
            int p1Points = int.Parse(p1.text);
            if(p1Points> p2Points)
            {
                win.text = "Gano P1";
                GameObject.Find("Ganado").SetActive(true);
            }else if (p1Points < p2Points)
            {
                win.text = "Gano P2";
                GameObject.Find("Ganado").SetActive(true);
            }else
            {
                win.text = "Empate";
                GameObject.Find("Ganado").SetActive(true);
            }
            if (Input.anyKey)
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }
}

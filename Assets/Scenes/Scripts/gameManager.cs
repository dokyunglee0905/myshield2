using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 


public class gameManager : MonoBehaviour
{
    public GameObject square;
    public GameObject gameOverTxt;
    public Text TimeTxt;

    //time setup
    float alive = 0.0f;

    public static gameManager i;

    private void Awake()
    {
        i = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeSquare", 0.0f,0.5f);
    }

    void makeSquare()
    {
        Instantiate(square);
    }

    // Update is called once per frame
    void Update()
    {
        alive += Time.deltaTime;
        TimeTxt.text = alive.ToString("N2");
    }

    public void gameOver()
    {
        gameOverTxt.SetActive(true);
        Time.timeScale = 0.0f;
    }
}

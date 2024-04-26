using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour
{
    private int score;

    public GameObject teleporter;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        checkForCoins();
    }

    public void increasePoints()
    {
        score += 50;
        scoreText.GetComponent<Text>().text = "Score: " + score;
    }

    public void checkForCoins()
    {
        int toCollect = GameObject.FindGameObjectsWithTag("Collectible").Length;

        if (toCollect <= 0)
        {
            teleporter.SetActive(true);
        }
    }
}

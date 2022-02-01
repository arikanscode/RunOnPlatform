using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public int goldCount = 0;
    public bool gameActive = true;

    public UnityEngine.UI.Text scoreText;
    public UnityEngine.UI.Text lostText;
    //public UnityEngine.UI.Button startButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addGold()
    {
        goldCount += 1;
        scoreText.text = "SCORE : " + (goldCount*10);
        
    }

    public void startGame()
    {
        gameActive = true;
       // startButton.gameObject.SetActive(false);
        
    }
}

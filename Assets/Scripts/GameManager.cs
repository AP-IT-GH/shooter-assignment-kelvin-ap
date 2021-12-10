using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject MainCanvas;
    public GameObject GameOverCanvas;
    private WaypointProgressTracker WPT;

    public enum GameStates
    {
        Playing,
        Complete,
        GameOver
    }
    public GameStates gameState = GameStates.Playing;


    // Start is called before the first frame update
    void Start()
    {
        WPT = FindObjectOfType<WaypointProgressTracker>();
    }

    private void OnCollisionEnter(Collision collision)
    {

    }

    // Update is called once per frame
    void Update()
    {
        //State Machine of the game
        switch (gameState)
        {
            case GameStates.Playing:
                /*if (end.finish)
                {
                    gameState = GameStates.GameOver;
                }*/
                break;

            case GameStates.GameOver:
                {
                    MainCanvas.SetActive(false);
                    GameOverCanvas.SetActive(true);
                    Time.timeScale = 0;
                    WPT.speed = 0f;
                }
                break;
        }
    }
}

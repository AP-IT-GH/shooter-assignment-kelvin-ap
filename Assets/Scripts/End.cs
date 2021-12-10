using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Utility;

public class End : MonoBehaviour
{
    public GameObject MainCanvas;
    public GameObject CheckPointCanvas;
    private WaypointProgressTracker WPT;

    //public bool finish = false;
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

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //finish = true;
            gameState = GameStates.GameOver;
            MainCanvas.SetActive(false);
            CheckPointCanvas.SetActive(true);
            WPT.enabled = false;
            Time.timeScale = 0;
            WPT.speed = 0f;
        }
    }
}

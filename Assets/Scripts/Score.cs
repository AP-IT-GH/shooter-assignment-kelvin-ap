using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    public int Count { get; set; } = 0;
    private Rigidbody Player;
    //denk over get object met tag, array en dan collide

    // Start is called before the first frame update
    void Start()
    {
        Player = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateScoreText(int score)
    {
        Count += score;
        ScoreText.text = "Score: " + Count;
        print("score omhoog");
    }
}

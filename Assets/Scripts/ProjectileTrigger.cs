using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProjectileTrigger : MonoBehaviour
{
    public Score score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            GameObject.FindGameObjectWithTag("TekstScore");
            score.UpdateScoreText(10);
        }
    }
}

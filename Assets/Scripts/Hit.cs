using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hit : MonoBehaviour
{
    public AudioClip audioclip;
    public GameObject explosionParticle;
    public Text ScoreText;
    //private int Count = 0;
    private Score points;


    // Start is called before the first frame update
    void Start()
    {
        //Count = 0;
        points = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Projectile")
        {
            print("hit");
            print(transform.position);
            Instantiate(explosionParticle, transform.position, transform.rotation);

            //Do explosion
            if (audioclip)
            {
                if (gameObject.GetComponent<AudioSource>())
                    gameObject.GetComponent<AudioSource>().PlayOneShot(audioclip);
                else
                    AudioSource.PlayClipAtPoint(audioclip, transform.position);
            }

            other.gameObject.SetActive(false);
            points.UpdateScoreText(1);
            Destroy(gameObject);
        }
    }
}

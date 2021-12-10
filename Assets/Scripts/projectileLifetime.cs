using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectileLifetime : MonoBehaviour
{
    float timer = 0;
    float lifeTime = 3f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < lifeTime)
            timer += Time.deltaTime;
        else
        {
            //after 3 seconds die
            Destroy(gameObject);
        }
    }
}

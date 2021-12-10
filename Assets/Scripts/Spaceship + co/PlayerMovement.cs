using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
    public float xSpeed = 20f;
    public float ySpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = CrossPlatformInputManager.GetAxis("Horizontal");
        float vertical = CrossPlatformInputManager.GetAxis("Vertical");

        float yOffset = vertical * Time.deltaTime * ySpeed;
        float xOffset = horizontal * Time.deltaTime * xSpeed;

        float yNewPos = yOffset + transform.localPosition.y;
        float xNewPos = xOffset + transform.localPosition.x;

        transform.localPosition = new Vector3(Mathf.Clamp(xNewPos,-30, 30), Mathf.Clamp(yNewPos, -10, 5), transform.localPosition.z);
        /*print(xOffset);
        print(yOffset);*/
    }
}

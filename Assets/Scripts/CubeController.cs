using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    GameManager gameManager;
    bool isGameStarted;
    float horizontalRotation, verticalRotation;
 
    // Update is called once per frame
    void Update()
    {
        //check with GameManager if game is started and running
        if (GameManager.isGameStarted)
        {
            //get input from user
            horizontalRotation = Input.GetAxis("Horizontal");
            verticalRotation = Input.GetAxis("Vertical");

            //rotate cube
            transform.Rotate(Vector3.up * horizontalRotation);
            transform.Rotate(Vector3.right * verticalRotation);

            //increase scale if space is pressed else reduce if scale is larger than 1
            if (Input.GetKey(KeyCode.Space))
                transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
            else
                if (transform.localScale.x > 1 && transform.localScale.y > 1 && transform.localScale.z > 1)
                transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoxScript : MonoBehaviour
{

    int speedChange = 20;



    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().SetRunSpeed(speedChange);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().SetRunSpeed(speedChange * -1);

    }
}

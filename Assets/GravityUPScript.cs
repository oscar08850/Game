using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityUPScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().SetGravityUpward();
    }

}

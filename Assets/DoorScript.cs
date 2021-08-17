using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{

    BoxCollider2D collider2D;
    GameObject gameObject;
    bool door = false;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            door = true;


            if (Input.GetButtonDown("Fire1"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
            }
        }
    }




}
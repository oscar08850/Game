using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{

    BoxCollider2D collider2D;
    GameObject gameObject;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetButtonDown("Fire1"))
            {

                SceneManager.LoadScene(1);
            }
        }
    }




}
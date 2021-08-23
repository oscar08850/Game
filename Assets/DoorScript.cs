using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{

    BoxCollider2D collider2D;
    GameObject gameObject;
    int nivel = -1;

    private void Start()
    {
        nivel = SceneManager.GetActiveScene().buildIndex;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        
        if (collision.gameObject.tag == "Player")
        {
            if (Input.GetButtonDown("Fire1"))
            {
                if ((GameObject.FindGameObjectWithTag("EstadoJuego").GetComponent<EstadoJuegoScript>().GetDoorStatus(1)))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

                }
                else Debug.Log("Acceso denegado");
            }
        }




    }
}
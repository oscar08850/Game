using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{

    bool transition = false;
    float speed = 3f;



    private void FixedUpdate()
    {
        Vector3 posicion = GameObject.FindGameObjectWithTag("Player").transform.position;
        Vector2 posicion2 = GameObject.FindGameObjectWithTag("Player").transform.position;

        if (transition == false)
        {
            Vector3 posCam = new Vector3(posicion.x, posicion.y, -40f);
            transform.position = posCam;
        }
        else //Transición de teletransporte
        {
            Vector3 vectorAux = new Vector3(posicion2.x, posicion2.y, -40f);

            if (Vector2.Distance(posicion, transform.position) > .1f)
            {
                transform.position = Vector3.MoveTowards(transform.position, vectorAux, Time.deltaTime * speed);
            }
            else
                 setTransition(5f);

        }
    }

    public void setTransition(float speed) {
        this.transition = !transition;
        this.speed = speed;
    }
}

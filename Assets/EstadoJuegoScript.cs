using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoJuegoScript : MonoBehaviour
{

    //public static EstadoJuego estadoJuego;


    void Awake()

    {
        if (estadoJuego == null)
        {
            estadoJuego = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (estadoJuego != this)
        {
            Destroy(gameObject);
        }

    }
}

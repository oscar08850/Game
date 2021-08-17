using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstadoJuegoScript : MonoBehaviour
{

    public static EstadoJuegoScript estadoJuego;

    public bool puerta1;


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

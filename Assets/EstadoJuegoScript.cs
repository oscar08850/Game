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
        Application.targetFrameRate = 60;

    }


    public bool setDoorUnlock() {
        puerta1 = true;
        return puerta1;
    }


    public bool GetDoorStatus(int numero)
    {
        switch (numero)
        {
            case 1:
                return puerta1;
            default:
                return false;
        }
    }


}

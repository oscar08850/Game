using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    BoxCollider2D collider2D;
    public bool activado = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        activado = true;
        Debug.Log("Activo");
    }
}
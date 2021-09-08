using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemsCollectorScript: MonoBehaviour
{

    private int cherries = 0;

    [SerializeField] private Text cherriesText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            cherries++;
            cherriesText.text = "Cherries: " + cherries;
            Destroy(collision.gameObject);
        
        }
    }
}

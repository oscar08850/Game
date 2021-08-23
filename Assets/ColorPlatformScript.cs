using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPlatformScript : MonoBehaviour
{
    int color = 0;
    // 0 = RED
    // 1 = BLUE
    // 2 = GREEN
    // 3 = YELLOW

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (color < 2)
            color++;
        else
            color = 0;

        SpriteRenderer renderer = gameObject.GetComponent<SpriteRenderer>(); //Get the renderer via GetComponent or have it cached previously

        switch (color) {
            case 0:
                renderer.color = new Color(255f, 0f, 0f, 1f); // Set to RED
                break;
            case 1:
                renderer.color = new Color(0f, 0f, 255f, 1f); // Set to BLUE
                break;
            case 2:
                renderer.color = new Color(0f, 255f, 0f, 1f); // Set to GREEN
                break;
            case 3:
                renderer.color = new Color(255f, 216f, 0f, 1f); // Set to YELLOW
                break;
            default:
                break;

        }


    }
}

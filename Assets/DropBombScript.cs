using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBombScript : MonoBehaviour
{
    // Start is called before the first frame update

    GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        plataforma = gameObject.transform.GetComponentInParent<Transform>() SetParent(transform);
    }

    void Update()
    {
        if (player.transform.position.x.Equals(transform.position.x))
        {
            Debug.Log("Drop the beat!!!");
        }
        else { }
    }
}

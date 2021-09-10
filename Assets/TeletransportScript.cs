using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeletransportScript : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypointIndex = 0;///


    private void OnTriggerEnter2D(Collider2D collision)
    {
      


        Vector3 newPosition = new Vector3(waypoints[currentWaypointIndex].transform.position.x + 2, waypoints[currentWaypointIndex].transform.position.y, 0f);
        //Debug.Log(newPosition);

        GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position = newPosition;

        GameObject.FindGameObjectWithTag("MainCamera").GetComponent<cameraScript>().setTransition(20f);







    }
}

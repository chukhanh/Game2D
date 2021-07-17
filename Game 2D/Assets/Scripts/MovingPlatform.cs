using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] private GameObject[]  waypoint;
    private int currentPoint = 0;

    [SerializeField] private float speed = 2f;
    // Update is called once per frame
    private void Update()
    {
        if(Vector2.Distance(waypoint[currentPoint].transform.position, transform.position) <.1f)
        {
        currentPoint++;
            if(currentPoint >= waypoint.Length)
            {
                currentPoint = 0;
            }
        } 
        transform.position = Vector2.MoveTowards(transform.position, waypoint[currentPoint].transform.position, Time.deltaTime * speed);
    }
}

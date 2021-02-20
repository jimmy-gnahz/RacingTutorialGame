using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIControl : MonoBehaviour
{
    public GameObject waypointsParent;
    List<GameObject> waypoints;
    //public GameObject waypoint2;

    GameObject target;
    int index = 1;
    public int speedController = 10;

    void Start()
    {
        Transform[] allChildren = waypointsParent.GetComponentsInChildren<Transform>();
        Debug.Log(allChildren.Length);
        waypoints = new List<GameObject>();
        foreach (Transform child in allChildren)
        {
            waypoints.Add(child.gameObject);
        }
        target = waypoints[1];
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 targetLocation = target.transform.position;
        Vector3 direction = targetLocation - transform.position;
        transform.Translate(direction.normalized / speedController);
        if (direction.magnitude < 1f) // hit waypoint 1
        {
            int nextIndex = (index + 1) % 3;
            if (nextIndex == 0)
            {
                index = 1;
            }
            else {
                index = nextIndex;
            }
            
            target = waypoints[index];
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MengikutiWaypoint : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoint;
    private int indeksWaypointSekarang = 0;
    [SerializeField] private float kecepatanPlatform = 2f;
    SpriteRenderer sr;
    private bool kondisiMenghadap = false;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (Vector2.Distance(waypoint[indeksWaypointSekarang].transform.position, transform.position) < 0.1f)
        {
            kondisiMenghadap = !kondisiMenghadap;
            sr.flipX = kondisiMenghadap;
            indeksWaypointSekarang++;
            if(indeksWaypointSekarang >= waypoint.Length)
            {
                indeksWaypointSekarang = 0;
                
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, waypoint[indeksWaypointSekarang].transform.position, kecepatanPlatform * Time.deltaTime);
    }
   
}

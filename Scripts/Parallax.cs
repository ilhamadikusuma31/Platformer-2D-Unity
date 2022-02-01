using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length, startpos;
    public GameObject cam;
    public float parallexEffect;
    public float Length = 10f;
    void Start()
    {
        startpos = transform.position.x;
        length = Length;
        if (length == 0f)
        {
            length = GetComponent<SpriteRenderer>().bounds.size.x;
        }
       
        
    }
    void Update()
    {
        float temp = (cam.transform.position.x * (1 - parallexEffect));
        float dist = (cam.transform.position.x * parallexEffect);
        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);
        //transform.position = new Vector3(startpos + dist, cam.transform.position.y, transform.position.z);
        if (temp > startpos + length) startpos += length;
        else if (temp < startpos - length) startpos -= length;
    }
}
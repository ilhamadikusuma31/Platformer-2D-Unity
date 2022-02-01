using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotasiSaw : MonoBehaviour
{
    [SerializeField] float kecepatan = 2f;
    void Update()
    {
        transform.Rotate(0,0,360*kecepatan*Time.deltaTime);
    }
}

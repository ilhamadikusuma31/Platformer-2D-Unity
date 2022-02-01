using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PengontrolKamera : MonoBehaviour
{
    [SerializeField] Transform pemain;
    [SerializeField] float margin_vertikal = 4f;
    [SerializeField] float batas_bawah = -0.4f;

    // Update is called once per frame
    void FixedUpdate()
    {
        
        transform.position = new Vector3(pemain.position.x, pemain.position.y+margin_vertikal, transform.position.z);
        if (pemain.position.y <= batas_bawah)
        {
            transform.position = new Vector3(pemain.position.x , batas_bawah, transform.position.z);
        }
        
    }
}

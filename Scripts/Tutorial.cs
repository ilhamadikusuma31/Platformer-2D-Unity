using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public Text textBox;
    public GameObject panelTutor;
    public string textTutor;
    private float kecepatanPemainAsli;

    public void Start()
    {
        kecepatanPemainAsli = PergerakanPemain.kecepatan;
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            StartCoroutine("setText");
            
        }
    }
    IEnumerator setText()
    {
        panelTutor.SetActive(true);
        textBox.GetComponent<Text>().text = textTutor;
        PergerakanPemain.kecepatan = 0; //pemain dipaksa ga bisa bergerak
        yield return new WaitForSeconds(2f);
        PergerakanPemain.kecepatan = kecepatanPemainAsli; //balikin kecepatannya biar bisa gerak
        panelTutor.SetActive(false);
        Destroy(this.gameObject);
    }

    
}

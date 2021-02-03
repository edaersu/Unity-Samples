using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kucukcemberkod : MonoBehaviour {

    Rigidbody2D fizik;
    public float hiz;
    bool hareketkontrol = false;
    GameObject oyunyonetici;

    void Start () {

        fizik = GetComponent<Rigidbody2D>();
        oyunyonetici = GameObject.FindGameObjectWithTag("oyunyoneticitag");
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (hareketkontrol == false)
        {
            fizik.MovePosition(fizik.position + Vector2.up * hiz * Time.deltaTime);
        }
        else
        {

        }

	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "donencembertag")
        {
            transform.SetParent(col.transform);
            hareketkontrol = true;
        }
        if (col.tag == "kucukcembertag")
        {
            oyunyonetici.GetComponent<Oyunyoneticisi>().OyunBitti();
        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tophareket : MonoBehaviour {

    public int hiz;
    public  Rigidbody fizik;
    int sayac = 0;
    public int tolamtop;
    public Text skor;
    public Text finish;

	void Start () {
        fizik = GetComponent<Rigidbody>();
	}
	
	
	void Update () {

        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(yatay, 0, dikey);
        fizik.AddForce(vec * hiz);

    }

    void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.tag == "tass")
        {
            Destroy(other.gameObject);
            
            sayac++;
            Debug.Log(sayac);
            skor.text = "Toplanan top: " + sayac;

            if(sayac== tolamtop)
            {
                finish.text = "Oyun bitti";
            }
        }
        
       
    }
}

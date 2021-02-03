using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anacember : MonoBehaviour {

    public GameObject kucukcember;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1")){
            cemberoluştur();
        }
		
	}

    void cemberoluştur()
    {
        Instantiate(kucukcember, transform.position, transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamerahareket : MonoBehaviour {

    public GameObject top;
    Vector3 fark;
	void Start () {
        fark = transform.position - top.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = top.transform.position + fark;

	}
}

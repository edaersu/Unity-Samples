using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Oyunyoneticisi : MonoBehaviour {


    GameObject donencember;
    GameObject anacember;
    public Animator anim;
	void Start () {

        donencember = GameObject.FindGameObjectWithTag("donencembertag");
        anacember = GameObject.FindGameObjectWithTag("anacembertag");
    }
	
	void Update () {
		
	}

    public void OyunBitti()
    {
        StartCoroutine(cagirilan());
    }

    IEnumerator cagirilan()
    {
        donencember.GetComponent < dondurme >().enabled= false;
        anacember.GetComponent<Anacember>().enabled = false;
        anim.SetTrigger("oyunbitti");

        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Ana Menu");

    }
}

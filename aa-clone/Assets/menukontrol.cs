using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menukontrol : MonoBehaviour {


    public void oyunagit()
    {

        SceneManager.LoadScene("level1");
    }

    public void cik()
    {
        Debug.Log("Oyun bitti");
        Application.Quit();
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AvancarCena : MonoBehaviour
{
    public string cena;

    // Update is called once per frame
    void Update()
    {

        // Fire 1 --> Touch, Ctrl + Left, Click + Left
        if (Input.GetButtonDown("Fire1"))
        {
            SceneManager.LoadScene(cena);
        }
    }
}
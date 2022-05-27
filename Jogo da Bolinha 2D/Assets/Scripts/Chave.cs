using System;
using System.Globalization;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chave : MonoBehaviour
{

    public GameObject porta;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) {
        FindObjectOfType<GerenciadorDeSons>().TocarSomDaChave();
        Debug.Log("Chave coletada");
        Destroy(porta);
        Destroy(this.gameObject);
    }
}

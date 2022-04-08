using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConroleDaBola : MonoBehaviour
{
    public float velocidadeDaBola;
    public Rigidbody2D oRigidbody2D;
    private Vector2 teclasApertadas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentarBola();

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SairDoJogo();
        }
    }

    private void MovimentarBola()
    {
        teclasApertadas = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        oRigidbody2D.velocity = teclasApertadas.normalized * velocidadeDaBola;
    }

    private void SairDoJogo()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorDeSons : MonoBehaviour
{
    public static GerenciadorDeSons instance;

    public AudioSource somDaChave;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        
        if(instance != null)
        {
            Destroy(this.gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TocarSomDaChave()
    {
        somDaChave.Play();
    }
}

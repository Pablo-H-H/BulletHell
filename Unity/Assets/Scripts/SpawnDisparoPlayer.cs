using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDisparoPlayer : MonoBehaviour
{
    public Vector3 offset;

    public GameObject disparo;
    public Quaternion rotacion;

    public KeyCode boton;
    public bool dispara;
    // Start is called before the first frame update
    void Start()
    {           
        Invoke("Disparo", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(boton))
        {
            dispara = true;
            Disparo();
        }
        else if (Input.GetKeyUp(boton))
        {
            dispara = false;
        }
    }

    public void Disparo()
	{
        Vector3 pos = (transform.position + offset);
        Instantiate(disparo, pos, rotacion);
        if (dispara)
        {
            Invoke("Disparo", 0.5f);
        }
                    
    }
}

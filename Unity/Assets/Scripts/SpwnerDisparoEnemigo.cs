using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpwnerDisparoEnemigo : MonoBehaviour
{
    public float vel_disparo;
    public int vidas;
    public GameObject disparo;

    // Start is called before the first frame update
    void Start()
    {
        vidas = 2;
        Invoke("Disparo_Espiral", 0.5f);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (vidas <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void Disparo_Espiral()
    {
        //Velocidad de disparo de 0.03
        Vector3 rotationVector = new Vector3(0, 0, 0);
        Quaternion rotation = Quaternion.Euler(rotationVector);

        Vector3 pos = (transform.position);
        Instantiate(disparo, pos, rotation);


        Invoke("Disparo_Espiral", vel_disparo);

    }

    public void restar_vida()
    {
        vidas--;
    }

    public void Autodestruir()
    {
        Destroy(gameObject);
    }

}

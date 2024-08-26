using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detector_Colisiones : MonoBehaviour
{

    public int contador_golpes; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Disparo(Clone)" || collision.gameObject.name == "Disparo")
        {
            collision.gameObject.GetComponent<MovimientoDisparo>().autodestruccion();
            contador_golpes--;
        }

        if (collision.gameObject.name == "SpaceshipEnemigosver2(Clone)" || collision.gameObject.name == "SpaceshipEnemigosver2")
        {
            collision.gameObject.GetComponent<SpwnerDisparoEnemigo>().restar_vida();
            contador_golpes--;
        }

        if (collision.gameObject.name == "Disparo Enemigo(Clone)" || collision.gameObject.name == "Disparo Enemigo")
        {
            collision.gameObject.GetComponent<DisparoEnemigos>().autodestruccion();
            contador_golpes--;
        }




    }

}

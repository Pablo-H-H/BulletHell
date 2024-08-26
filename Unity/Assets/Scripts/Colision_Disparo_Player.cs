using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision_Disparo_Player : MonoBehaviour
{
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
        if(collision.gameObject.name == "Disparo(Clone)" || collision.gameObject.name == "Disparo")
        {
            collision.gameObject.GetComponent<MovimientoDisparo>().autodestruccion();
            Destroy(gameObject);
        }

        if (collision.gameObject.name == "SpaceshipEnemigosver2(Clone)" || collision.gameObject.name == "SpaceshipEnemigosver2")
        {
            collision.gameObject.GetComponent<SpwnerDisparoEnemigo>().restar_vida();
            Destroy(gameObject);
        }

        if (collision.gameObject.name == "Disparo Enemigo(Clone)" || collision.gameObject.name == "Disparo Enemigo")
        {
            collision.gameObject.GetComponent<DisparoEnemigos>().autodestruccion();
            Destroy(gameObject);
        }



        Debug.Log(collision.gameObject.name);

    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

}

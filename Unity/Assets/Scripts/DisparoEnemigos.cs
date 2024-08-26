using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoEnemigos : MonoBehaviour
{
    public int speed;
    private GameObject player;
    Vector3 posJugador;
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameManager = GameObject.FindWithTag("GameManager");
        gameManager.GetComponent<GameManager>().SumarContador();

        player = GameObject.FindWithTag("Player");
        posJugador = player.transform.position;
        speed = 200;
        Invoke("DestruitTiempo", 5);
    }

    // Update is called once per frame
    void Update()
    {
        var step = speed * Time.deltaTime; // calculate distance to move
        transform.position = Vector3.MoveTowards(transform.position, posJugador, step);
    }

    public void DestruitTiempo()
    {
        Destroy(gameObject);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    public void autodestruccion()
    {
        Destroy(gameObject);
    }
    void OnDestroy()
    {
        GameObject gameManager = GameObject.FindWithTag("GameManager");
        gameManager.GetComponent<GameManager>().RestarContador();
    }
}

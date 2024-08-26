using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDisparo : MonoBehaviour
{
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestruitTiempo", 5);
        GameObject gameManager = GameObject.FindWithTag("GameManager");
        gameManager.GetComponent<GameManager>().SumarContador();
}

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
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

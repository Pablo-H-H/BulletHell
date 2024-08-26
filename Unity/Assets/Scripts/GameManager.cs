using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector3 offset;
    public Vector3 spawnBoss1;
    public Vector3 spawnBoss2;
    public Vector3 spawnBoss3;


    public GameObject enemigo;
    public GameObject boss;


    public Quaternion rotacion;
    public int contador;

    public int contadorBalas;

    // Start is called before the first frame update
    void Start()
    {
        contador = 2;
        Invoke("SpwanearEnemigosUno", 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SumarContador()
    {
        contadorBalas++;
    }
    public void RestarContador()
    {
        contadorBalas--;
    }

    public void SpwanearEnemigosUno()
    {

        Vector3 offset = new Vector3(Random.Range(-350.0f, 350.0f), -10f, Random.Range(-100.0f, 200.0f));
        Vector3 pos = (transform.position + offset);
        Instantiate(enemigo, pos, rotacion);

        contador--;
        if (contador == 0)
        {
            contador = 5;
            Invoke("SpwanearEnemigosDos", 5f);
        }
        else
        {
            Invoke("SpwanearEnemigosUno", 5f);
        }
        
    }

    public void SpwanearEnemigosDos()
    {

        Vector3 offset = new Vector3(Random.Range(-350.0f, 350.0f), -10f, Random.Range(-100.0f, 200.0f));
        Vector3 pos = (transform.position + offset);
        Instantiate(enemigo, pos, rotacion);

        offset = new Vector3(Random.Range(-350.0f, 350.0f), -10f, Random.Range(-100.0f, 200.0f));
        pos = (transform.position + offset);
        Instantiate(enemigo, pos, rotacion);

        contador--;
        if (contador == 0)
        {
            contador = 2;
            Invoke("SpawnearBoss", 15f);
        }
        else
        {
            Invoke("SpwanearEnemigosDos", 5f);
        }

    }

    public void SpawnearBoss()
    {
        Instantiate(boss, spawnBoss1, rotacion);
        Invoke("espawmDos", 14f);
    }

    public void espawmDos()
    {
        Vector3 offset = new Vector3(Random.Range(-350.0f, 350.0f), -10f, Random.Range(100.0f, 200.0f));
        Vector3 pos = (transform.position + offset);
        Instantiate(enemigo, pos, rotacion);

        offset = new Vector3(Random.Range(-350.0f, 350.0f), -10f, Random.Range(100.0f, 200.0f));
        pos = (transform.position + offset);
        Instantiate(enemigo, pos, rotacion);
        Invoke("espawmTres", 12f);
    }

    public void espawmTres()
    {
        Vector3 offset = new Vector3(Random.Range(-350.0f, 350.0f), -10f, Random.Range(100.0f, 200.0f));
        Vector3 pos = (transform.position + offset);
        Instantiate(enemigo, pos, rotacion);

        offset = new Vector3(Random.Range(-350.0f, 350.0f), -10f, Random.Range(100.0f, 200.0f));
        pos = (transform.position + offset);
        Instantiate(enemigo, pos, rotacion);

        offset = new Vector3(Random.Range(-350.0f, 350.0f), -10f, Random.Range(100.0f, 200.0f));
        pos = (transform.position + offset);
        Instantiate(enemigo, pos, rotacion);

        Invoke("espawmunu",30f);

    }

    public void espawmunu()
    {
        Vector3 offset = new Vector3(Random.Range(-350.0f, 350.0f), -10f, Random.Range(100.0f, 200.0f));
        Vector3 pos = (transform.position + offset);
        Instantiate(enemigo, pos, rotacion);

        Invoke("SpawnearBossDos", 41f);

    }


    public void SpawnearBossDos()
    {
        Instantiate(boss, spawnBoss2, rotacion);
        Invoke("Destruirtodo", 20f);
        
    }

    public void Destruirtodo()
    {
        GameObject Enemigo = GameObject.FindWithTag("Enemy");
        Enemigo.GetComponent<DisparoBoss>().Autodestruir();
        Invoke("Destruirtododos", 30f);
    }

    public void Destruirtododos()
    {
        GameObject Enemigo = GameObject.FindWithTag("Enemy");
        Enemigo.GetComponent<DisparoBoss>().Autodestruir();
    }


}

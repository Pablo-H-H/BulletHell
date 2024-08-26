using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoBoss : MonoBehaviour
{

    public Vector3 offset;

    public GameObject disparo;
    public int rotacionY;
    public int rotacionY2;
    public float velocidadDisparo;
    public int contador;


    // Start is called before the first frame update
    void Start()
    {
        Invoke("Cuadrado", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Autodestruir()
    {
        Destroy(gameObject);
    }



    public void Disparo_Espiral_Invertido()
    {
        //Velocidad de disparo de 0.03
        Vector3 rotationVector = new Vector3(0, rotacionY, 0);
        Quaternion rotation = Quaternion.Euler(rotationVector);

        Vector3 pos = (transform.position + offset);
        Instantiate(disparo, pos, rotation);
        rotacionY = rotacionY - 70;

        contador = contador + 1;
        if (contador < 180)
        {
            Invoke("Disparo_Espiral_Invertido", velocidadDisparo);
        }
        else
        {
            rotacionY = 0;
            contador = 0;
            Invoke("Flor", 1f);
        }
    }

    public void Flor()
    {
        //Velocidad de disparo de 0.09
        Vector3 rotationVector = new Vector3(0, rotacionY, 0);
        Quaternion rotation = Quaternion.Euler(rotationVector);

        //Velocidad de disparo de 0.03
        Vector3 rotationVector2 = new Vector3(0, rotacionY2, 0);
        Quaternion rotation2 = Quaternion.Euler(rotationVector2);

        Vector3 pos = (transform.position + offset);
        Instantiate(disparo, pos, rotation);
        Instantiate(disparo, pos, rotation2);

        rotacionY = rotacionY - 70;
        rotacionY2 = rotacionY2 + 70;

        contador = contador + 1;
        if (contador < 750)
        {
            Invoke("Flor", 0.03f);
        }
        else
        {
            rotacionY = 0;
            contador = 0;
            Vector3 newpos = new Vector3(-270f, 2.5f, 200f);
            transform.Translate(newpos);
            Invoke("Cuadrado", 10f);
        }

    }

    public void Espawnear(int divisiones, int rotacion)
    {
        Vector3 pos = (transform.position + offset);

        Vector3 rotationVector = new Vector3(0, 0, 0);
        Quaternion rotation = Quaternion.Euler(rotationVector);

        float angle_div = 360 / divisiones;
        float cont_div = angle_div;

        for (int i = 0; i < divisiones; i++){
            rotationVector = new Vector3(0, angle_div + rotacion, 0);
            rotation = Quaternion.Euler(rotationVector);

            Instantiate(disparo, pos, rotation);

            angle_div = angle_div + cont_div;
        }

        
    }

    public void Cuadrado()
    {
        Espawnear(6, rotacionY);

        rotacionY = rotacionY - 3;


        contador = contador + 1;
        if (contador < 200)
        {
            Invoke("Cuadrado", velocidadDisparo);
        }
        else
        {
            rotacionY = 0;
            contador = 0;
            Invoke("Disparo_Espiral_Invertido", 1f);
        }

    }


}


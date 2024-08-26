using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextGolpesRecibidos : MonoBehaviour
{
    public TMP_Text contador;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        GameObject gameManager = GameObject.FindWithTag("Player");
        contador.text = gameManager.GetComponent<Detector_Colisiones>().contador_golpes.ToString();
    }
}

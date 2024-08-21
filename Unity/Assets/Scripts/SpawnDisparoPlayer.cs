using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDisparoPlayer : MonoBehaviour
{

    public GameObject disparo;
    public Quaternion rotacion;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Disparo", 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Disparo()
	{
        Instantiate(disparo, transform.position, rotacion);
        Invoke("Disparo", 0.5f);
    }
}

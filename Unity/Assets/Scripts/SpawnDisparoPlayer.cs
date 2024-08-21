using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDisparoPlayer : MonoBehaviour
{
    public Vector3 offset;

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
        Vector3 pos = (transform.position + offset);
        Instantiate(disparo, pos, rotacion);
        Invoke("Disparo", 0.5f);
    }
}

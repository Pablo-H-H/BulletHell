using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector3 offset;

    public GameObject disparo;
    public Quaternion rotacion;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisparoBoss()
    {
        Vector3 pos = (transform.position + offset);
        Instantiate(disparo, pos, rotacion);
        Invoke("Disparo", 0.5f);
    }

}

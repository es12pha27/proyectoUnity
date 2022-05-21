using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonido : MonoBehaviour
{
    public float timeDeVida;
    // Start is called before the first frame update
    void Start()
    {
       Destroy(gameObject,timeDeVida); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

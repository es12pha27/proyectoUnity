using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Aro : MonoBehaviour
{
    public GameObject confeti;
    int puntos=0;
    public GameObject sonidoPunto;
    public Text punto;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        GameObject gameObjectC=Instantiate(confeti);
       Instantiate(sonidoPunto);
        Destroy(gameObjectC,5);
        puntos ++;
        Debug.Log("Punto !!!");
        Debug.Log(puntos);
        punto.text=puntos.ToString();
    }
}

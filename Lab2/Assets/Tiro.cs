using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tiro : MonoBehaviour
{
    public float velocidad;
    public Vector3 direccion;
    public Rigidbody rb;
    public float speed=10f;
    public Slider slider;
    public Text textForce;
    
    // Start is called before the first frame update
    void Start()
    {
         rb=GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    public void Lanzar(){
        rb.isKinematic = false;
        rb.AddForce(direccion*velocidad*(slider.value*2));

    }
    public void Fuerza(){
        textForce.text=(slider.value*2).ToString();
    }

    void FixedUpdate(){
         if(!Input.GetKey(KeyCode.R)){
              rb.isKinematic = false;
        if(Input.GetKey(KeyCode.A)){            
            rb.MovePosition(rb.position+Vector3.forward*speed*Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.D)){
            rb.MovePosition(rb.position+Vector3.back*speed*Time.deltaTime);
        }
         else if(Input.GetKey(KeyCode.S)){
            rb.MovePosition(rb.position+Vector3.left*speed*Time.deltaTime);
        }
         else if(Input.GetKey(KeyCode.W)){
            rb.MovePosition(rb.position+Vector3.right*speed*Time.deltaTime);
        }}
        else{
            rb.isKinematic = true;
        }
    }
}

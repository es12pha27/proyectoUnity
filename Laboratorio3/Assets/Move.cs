using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float velocidad;
    [Header("Animation")] 
    private Animator  animator;

    // Start is called before the first frame update
    void Start()
    {
        animator=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float movimientoHorizontal=Input.GetAxis("Horizontal");
        animator.SetFloat("Horizontal",Mathf.Abs(movimientoHorizontal*velocidad));
        MoveSystem(movimientoHorizontal);
    }
    public void MoveSystem(float x){
        GetComponent<Transform>().Translate(x*velocidad*Time.deltaTime,0,0);
    }
}

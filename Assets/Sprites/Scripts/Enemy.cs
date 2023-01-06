using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;
using Random = UnityEngine.Random;

public class Enemy : MonoBehaviour
{
    public float speed;
    public bool esDerecha;

    public float contadorT;

    public float TiempoCambiar;

    public Transform objetivo;
    public bool debePerseguir;
    public float distancia; // que si se acerca lo suficiente lo empezamos a perseguir;
    public float speedt;

    public float distanciaAbsoluta;

   




    Animator anim;
   
    void Start()
    {
        contadorT= TiempoCambiar;
        anim = GetComponent<Animator>();
       

    }
    

    void Update()
    {

        if (esDerecha == true)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
            transform.localScale = new Vector3(-1, 1, 1);
            anim.SetBool("walk", true);
        }

        if (esDerecha == false)
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
            transform.localScale = new Vector3(1, 1, 1);
            anim.SetBool("walk", true);
        }
        contadorT -= Time.deltaTime;

        if (contadorT <= 0)
        {
            contadorT = TiempoCambiar;
            esDerecha = !esDerecha;
        }
        distancia = objetivo.position.x - transform.position.x;

        distanciaAbsoluta = Mathf.Abs(distancia);

        if (debePerseguir == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, objetivo.position, speedt * Time.deltaTime);
        }
        if (distancia > 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (distancia < 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }

        if(distanciaAbsoluta  < 5)
        {
            debePerseguir = true;
        }
        else
        {
            debePerseguir = false;
        }
    }
}

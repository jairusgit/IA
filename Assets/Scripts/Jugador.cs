using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour {

    public float velocidad = 5;
	
    void FixedUpdate () {

        //Capturo el movimiento en los ejes
        float movimientoH = Input.GetAxis("Horizontal");
        float movimientoV = Input.GetAxis("Vertical");

        //Genero el vector de movimiento
        Vector3 movimiento = new Vector3(movimientoH, 0, movimientoV);

        //Muevo el jugador
        transform.position += movimiento * velocidad * Time.deltaTime;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coleccionable"))
        {
            Destroy(other.gameObject);
            
            //Capturo un array con todos los objetos que tengan la etiqueta enemigo
            GameObject[] enemigos = GameObject.FindGameObjectsWithTag("Enemigo");

            //Recorro ese array y los destruyo
            foreach (GameObject enemigo in enemigos) Destroy(enemigo);
        }
    }
}
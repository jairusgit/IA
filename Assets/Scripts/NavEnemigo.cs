using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavEnemigo : MonoBehaviour {

    NavMeshAgent agente;
    GameObject jugador;

    void Start () {

        //Busco el jugador
        jugador = GameObject.Find("Jugador");

        //Capturamos el componente agente del jugador
        agente = GetComponent<NavMeshAgent>();

    }
	
    // Update is called once per frame
    void Update () {

        agente.SetDestination(jugador.transform.position);
    }
}
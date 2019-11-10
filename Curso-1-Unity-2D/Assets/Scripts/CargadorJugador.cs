using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargadorJugador : MonoBehaviour
{

    public GameObject jugador;
    // Start is called before the first frame update
    void Start()
    {
        if (JugadorControlador.instancia == null)
        {
            Instantiate(jugador);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

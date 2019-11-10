using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaEntrada : MonoBehaviour
{
    public string nombreTransicion;
    // Start is called before the first frame update
    void Start()
    {
      if(nombreTransicion == JugadorControlador.instancia.nombreAreaTransicion)
        {
            JugadorControlador.instancia.transform.position = transform.position;
        }  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaSalida : MonoBehaviour
{

    public string areaACargar;
    public string nombreAreaTransicion;
    public AreaEntrada laEntrada;

    // Start is called before the first frame update
    void Start()
    {
        laEntrada.nombreTransicion = nombreAreaTransicion;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D otro)
    {
        if(otro.tag == "Player")
        {
            SceneManager.LoadScene(areaACargar);

            JugadorControlador.instancia.nombreAreaTransicion = nombreAreaTransicion;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraControlador : MonoBehaviour
{

    public Transform objetivo;

    // Start is called before the first frame update
    void Start()
    {
        objetivo = JugadorControlador.instancia.transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = new Vector3(objetivo.position.x, objetivo.position.y, transform.position.z);
    }
}

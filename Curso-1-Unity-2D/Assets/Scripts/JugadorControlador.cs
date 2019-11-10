using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JugadorControlador : MonoBehaviour
{
    public Rigidbody2D elRB;
    public int valor;
    public float velocidadMov;
    public Animator miAnim;

    public static JugadorControlador instancia;
    public string nombreAreaTransicion;
    
    // Start is called before the first frame update
    void Start()
    {
        if (instancia == null)
        {
            instancia = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        elRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * velocidadMov;
        miAnim.SetFloat("moverX", elRB.velocity.x);
        miAnim.SetFloat("moverY", elRB.velocity.y);

        if (Input.GetAxisRaw("Horizontal") == 1||
            Input.GetAxisRaw("Horizontal") == -1||
            Input.GetAxisRaw("Vertical") == 1 ||
            Input.GetAxisRaw("Vertical") == -1
            )
        {
            miAnim.SetFloat("ultimaPosX",Input.GetAxisRaw("Horizontal"));
            miAnim.SetFloat("ultimaPosY", Input.GetAxisRaw("Vertical"));
        }
    }
}

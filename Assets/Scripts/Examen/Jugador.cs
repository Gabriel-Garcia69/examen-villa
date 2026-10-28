using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float velocidad = 5f;

    Rigidbody2D rb;
    Vector2 movimiento;
    Vector2 inicio;
    float angulo;
    float anguloInicial;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        inicio = rb.position;
        anguloInicial = rb.rotation;
        angulo = anguloInicial;
    }

    void Update()
    {
        bool arriba, abajo, izquierda, derecha;

        if (name == "Player1")
        {
            arriba = Input.GetKey(KeyCode.W);
            abajo = Input.GetKey(KeyCode.S);
            izquierda = Input.GetKey(KeyCode.A);
            derecha = Input.GetKey(KeyCode.D);
        }
        else
        {
            arriba = Input.GetKey(KeyCode.UpArrow);
            abajo = Input.GetKey(KeyCode.DownArrow);
            izquierda = Input.GetKey(KeyCode.LeftArrow);
            derecha = Input.GetKey(KeyCode.RightArrow);
        }

        movimiento = Vector2.zero;

        if (arriba) { movimiento = Vector2.up; angulo = 90; }
        else if (abajo) { movimiento = Vector2.down; angulo = 270; }
        else if (izquierda) { movimiento = Vector2.left; angulo = 180; }
        else if (derecha) { movimiento = Vector2.right; angulo = 0; }
    }

    void FixedUpdate()
    {
        rb.linearVelocity = movimiento * velocidad;
        rb.rotation = angulo;
    }

    public void Morir()
    {
        rb.position = inicio;
        angulo = anguloInicial;
    }
}

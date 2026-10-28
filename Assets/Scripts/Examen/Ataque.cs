using UnityEngine;

public class Ataque : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Espalda"))
        {
            other.GetComponentInParent<Jugador>().Morir();
        }
    }
}

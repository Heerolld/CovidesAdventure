using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform target; // Referência ao Transform do jogador para seguir
    public float moveSpeed = 3f; // Velocidade de movimento do inimigo

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Obtém o Rigidbody2D do inimigo
    }

    void Update()
    {
        if (target != null)
        {
            Vector2 direction = (target.position - transform.position).normalized; // Calcula a direção para o jogador
            rb.velocity = direction * moveSpeed; // Define a velocidade do Rigidbody na direção do jogador
        }
    }
}

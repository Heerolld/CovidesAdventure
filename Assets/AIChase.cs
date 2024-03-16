using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public Transform target; // Refer�ncia ao Transform do jogador para seguir
    public float moveSpeed = 3f; // Velocidade de movimento do inimigo

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Obt�m o Rigidbody2D do inimigo
    }

    void Update()
    {
        if (target != null)
        {
            Vector2 direction = (target.position - transform.position).normalized; // Calcula a dire��o para o jogador
            rb.velocity = direction * moveSpeed; // Define a velocidade do Rigidbody na dire��o do jogador
        }
    }
}

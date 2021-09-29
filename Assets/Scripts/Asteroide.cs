using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroide : MonoBehaviour
{
    public Rigidbody2D meuRigidboby;
    public float velocidadeMaxima = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        Vector2 direcao = Random.insideUnitCircle;
        direcao *= velocidadeMaxima;
        meuRigidboby.velocity= direcao;
        
    }

    void OnTriggerEnter2D(Collider2D outro)
    {
        Destroy(gameObject);
        Destroy(outro.gameObject);
    }

}

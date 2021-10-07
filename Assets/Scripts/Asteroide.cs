using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroide : MonoBehaviour
{
    public static System.Action AsteroideDestruido = null;
    public Rigidbody2D meuRigidboby;
    public EfeitoAsteroideDestruido prefabEfeito;
    public Rigidbody2D prefabFragmentos;
    public int quantidadeFragmento = 3;
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
      

        for (int i = 0; i < quantidadeFragmento; i++)
        {
            Instantiate(prefabFragmentos, meuRigidboby.position, Quaternion.identity);
        }

        if(AsteroideDestruido != null)
        {
            AsteroideDestruido();
        }

        Instantiate(prefabEfeito, meuRigidboby.position, Quaternion.identity);

        Destroy(gameObject);
        Destroy(outro.gameObject);

    }

}

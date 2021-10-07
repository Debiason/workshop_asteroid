using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComportamentoJogador : MonoBehaviour
{
    public Rigidbody2D meuRigidbody;
    public float aceleracao = 1.0f;
    public float velocidadeAngular = 180.0f;
    public float velocidadeMaxima = 4.0f;

    public Rigidbody2D prefabProjetil;
    public float velocidadeProjetil= 10.0f;

    public float duracaoProjetil = 1.0f;

    public Sprite spriteInicio;
    public Sprite spriteMovendo;

    private SpriteRenderer spriteRender;

    // Start is called before the first frame update
    void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
        if (spriteRender.sprite==null)
        {
            spriteRender.sprite = spriteInicio;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D projetil = Instantiate(prefabProjetil,meuRigidbody.position, Quaternion.identity);
            projetil.velocity = transform.up * velocidadeProjetil;
            Destroy(projetil.gameObject,duracaoProjetil);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            ChangeTheDamnSprite ();
            Vector3 direcao = transform.up * aceleracao;
            meuRigidbody.AddForce(direcao, ForceMode2D.Force);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            meuRigidbody.rotation += velocidadeAngular * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            meuRigidbody.rotation -= velocidadeAngular * Time.deltaTime;
        }

        if (meuRigidbody.velocity.magnitude > velocidadeMaxima)
        {
            meuRigidbody.velocity = Vector2.ClampMagnitude(meuRigidbody.velocity,velocidadeMaxima);
        }
    }

    void ChangeTheDamnSprite ()
    {
        if (spriteRender.sprite == spriteInicio) 
        {
            spriteRender.sprite = spriteMovendo;
        }
        else
        {
            spriteRender.sprite = spriteInicio; 
        }
        
    }


    void OnTriggerEnter2D(Collider2D outro)
    {
        Destroy(gameObject);
    }

}
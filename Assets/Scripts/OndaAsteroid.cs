using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OndaAsteroid : MonoBehaviour
{
    public Asteroide prefabAsteroid;
    public int quantoAsteroide=3;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < quantoAsteroide; i++)
        {
            float x = Random.Range(-7.0f,7.0f);
            float y = Random.Range(-4.0f,4.0f);
            Vector3 posicao = new Vector3(x,y,0.0f);
            Instantiate(prefabAsteroid,posicao,Quaternion.identity);
        }
        
    }

}

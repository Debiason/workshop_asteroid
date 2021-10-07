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
            float x = Random.Range(-9.0f,9.0f);
            float y = Random.Range(-6.0f,6.0f);

            if ((x >= -1.0f) && (x <= 1.0f))
            {
                 x = Random.Range(-9.0f,9.0f);
            }

            if ((y >= -1.0f) && (y <= 1.0f))
            {
                 y = Random.Range(-6.0f,6.0f);
            }

            Vector3 posicao = new Vector3(x,y,0.0f);
            Instantiate(prefabAsteroid,posicao,Quaternion.identity);
        }
        
    }

}

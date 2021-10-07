using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayCamera : MonoBehaviour
{
    public static GamePlayCamera instancia;
    public Camera minhaCamera;

    void Awake()
    {
        instancia= this;
    }
}

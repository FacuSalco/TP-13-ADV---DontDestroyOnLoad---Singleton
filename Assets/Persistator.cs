using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persistator : MonoBehaviour
{
    public static Persistator instance; //Crear variable del mismo tipo de la clase (nombre del script)

    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (instance == null)
        {
            instance = this;
        }

        else
        {
            Destroy(gameObject);
        }

    }
}

using System.Collections.Generic;
using UnityEngine;

public class RespuestaCorrecta : MonoBehaviour
{
    public void SiguientePregunta(GameObject prefab){
        Instantiate(prefab, transform.root);
        Destroy(transform.parent.gameObject);
    }
}

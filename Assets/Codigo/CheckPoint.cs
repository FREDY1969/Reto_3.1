using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            col.gameObject.GetComponent<MovimientoPersonaje>().posicionInicio = transform.position;
        }
    }
}

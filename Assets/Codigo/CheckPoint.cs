using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public AudioClip pickupSound;
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            col.gameObject.GetComponent<MovimientoPersonaje>().posicionInicio = transform.position;
            AudioSource.PlayClipAtPoint(pickupSound, Camera.main.transform.position, 1f);
        }
    }
}

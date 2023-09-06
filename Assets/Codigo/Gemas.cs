using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gemas : MonoBehaviour
{
    public AudioClip pickupSound;
    public int coinValue = 1;
    public Text scoreText;

    private bool isCollected = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Coin collected!");
        if (other.CompareTag("Player") && !isCollected)
        {
            Debug.Log("Coin collected2!");
            isCollected = true;
            CollectCoin();
        }
    }

    private void CollectCoin()
    {
        // Reproducir el sonido de recogida
        if (pickupSound != null)
        {
            AudioSource.PlayClipAtPoint(pickupSound, transform.position);
        }

        // Actualizar los puntos
        GameManager.Instance.UpdateScore(coinValue);

        // Ocultar la moneda
        gameObject.SetActive(false);
    }
}

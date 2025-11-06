using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemPickup : MonoBehaviour
{
    public PauseManager pauseManager;  // Reference to the PauseManager

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            audioManager.PlaySFX(audioManager.gemPickup);
            Debug.Log("Gem Picked Up! Game Win Triggered");
            if (pauseManager != null)
            {
                pauseManager.TriggerGameWin();
            }
            Destroy(gameObject);  // Destroy the gem after pickup
        }
    }
}

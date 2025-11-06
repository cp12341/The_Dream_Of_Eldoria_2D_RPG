using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio source")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("Audio clip")]
    public AudioClip background;
    public AudioClip attack;
    public AudioClip arrow;
    public AudioClip hurt;
    public AudioClip coin;
    public AudioClip heart;
    public AudioClip treasureChest;
    public AudioClip sign;
    public AudioClip magicPotion;
    public AudioClip healthBottle;
    public AudioClip door;
    public AudioClip switchSound;
    public AudioClip gemPickup;

    private void Start()
    {
        musicSource.clip = background;
        // musicSource.loop = true;  // Enable looping
        musicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}

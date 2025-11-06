using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sign : Interactable
{
    // public Signal contextOn;
    // public Signal contextOff;
    public GameObject dialogBox;
    public Text dialogText;
    public string dialog;
    
    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public virtual void Update()
    {
        // if (Input.GetKeyDown(KeyCode.Space) && playerInRange)
        if (Input.GetButtonDown("attack") && playerInRange)
        {
            audioManager.PlaySFX(audioManager.sign);
            Debug.Log("Mouse Click Detected");
            if (dialogBox.activeInHierarchy)
            {
                dialogBox.SetActive(false);
            }
            else 
            {
                dialogBox.SetActive(true);
                dialogText.text = dialog;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !other.isTrigger)
        {
            audioManager.PlaySFX(audioManager.sign);
            context.Raise();
            playerInRange = false;
            dialogBox.SetActive(false);
        }
    }
}

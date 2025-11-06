using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogManager : MonoBehaviour
{
    public Text dialogText;   // Use UnityEngine.UI.Text
    public Button nextButton;
    public string[] dialogLines;
    private int currentLineIndex = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        nextButton.onClick.AddListener(ShowNextLine);
        dialogText.text = dialogLines[currentLineIndex];
    }

    void ShowNextLine()
    {
        currentLineIndex++;
        if (currentLineIndex < dialogLines.Length)
        {
            dialogText.text = dialogLines[currentLineIndex];
        }
        else
        {
            gameObject.SetActive(false);  // Hide the dialog box after all lines are read
        }
    }
}

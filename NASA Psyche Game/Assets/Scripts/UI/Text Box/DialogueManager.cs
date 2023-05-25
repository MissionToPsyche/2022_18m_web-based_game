using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    private GameObject diaBox;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public Image itemIcon;

    // Start is called before the first frame update
    void Start()
    {
        diaBox = GameObject.Find("DialogueBox");
        diaBox.SetActive(false);
        sentences = new Queue<string>();
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && diaBox.activeSelf == true) {
            DisplayNextSentence();
        }
    }

    public void StartDialogue(Dialogue dialogue) {
        diaBox.SetActive(true);
        nameText.text = dialogue.name;
        
        if (dialogue.itemIcon != null) {
            itemIcon.sprite = dialogue.itemIcon;
            itemIcon.color = new Color(1, 1, 1, 1);
        }
        else {
            itemIcon.color = new Color(1, 1, 1, 0);
        }
        
        // Debug.Log("Convo started w/: " + dialogue.name);

        sentences.Clear();

        foreach(string sentence in dialogue.sentences) {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence() {
        if (sentences.Count == 0) {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        // Debug.Log("Sentence: " + sentence);
        dialogueText.text = sentence;
    }

    void EndDialogue() {
        // Debug.Log("End of convo");
        diaBox.SetActive(false);
    }
}

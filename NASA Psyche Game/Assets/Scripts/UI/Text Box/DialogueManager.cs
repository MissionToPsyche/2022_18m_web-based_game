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
        // find the dialogue box in the game and hide it
        diaBox = GameObject.Find("DialogueBox");
        diaBox.SetActive(false);
        sentences = new Queue<string>();
    }

    // if the textbox is active and the spacebar is pressed, advance text
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && diaBox.activeSelf == true) {
            DisplayNextSentence();
        }
    }

    // starts dialogue
    public void StartDialogue(Dialogue dialogue) {
        // show the textbox
        diaBox.SetActive(true);
        nameText.text = dialogue.name;
        
        // if the item has an icon, display it. otherwise don't display anything
        if (dialogue.itemIcon != null) {
            itemIcon.sprite = dialogue.itemIcon;
            itemIcon.color = new Color(1, 1, 1, 1);
        }
        else {
            itemIcon.color = new Color(1, 1, 1, 0);
        }

        sentences.Clear();

        // queue up all parts of dialogue
        foreach(string sentence in dialogue.sentences) {
            sentences.Enqueue(sentence);
        }

        // advance to the first set of dialogue
        DisplayNextSentence();
    }

    // iterates through the sentence queue and displays a new sentence, if applicable 
    public void DisplayNextSentence() {
        // if there aren't any sentences, end dialogue
        if (sentences.Count == 0) {
            EndDialogue();
            return;
        }

        // get next sentence and display it
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    // hides textbox
    void EndDialogue() {
        diaBox.SetActive(false);
    }
}

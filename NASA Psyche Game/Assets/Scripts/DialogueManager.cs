using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    private Queue<string> sentences;
    private GameObject diaBox;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    // Start is called before the first frame update
    void Start()
    {
        diaBox = GameObject.Find("DialogueBox");
        diaBox.SetActive(false);
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue) {
        diaBox.SetActive(true);
        nameText.text = dialogue.name;
        Debug.Log("Convo started w/: " + dialogue.name);

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
        Debug.Log("Sentence: " + sentence);
        dialogueText.text = sentence;
    }

    void EndDialogue() {
        Debug.Log("End of convo");
        diaBox.SetActive(false);
    }
}

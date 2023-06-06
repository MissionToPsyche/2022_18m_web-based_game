using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Dialogue
{
    public string name;

    public string[] sentences;

    public Sprite itemIcon;

    // initializes dialogue's title and body
    public Dialogue(string diagTitle, string[] diagBody) {
        name = diagTitle;
        sentences = diagBody;
    }

    // initializes dialogue's title, body, and image
    public Dialogue(string diagTitle, string[] diagBody, Sprite icon) {
        name = diagTitle;
        sentences = diagBody;
        itemIcon = icon;
    }
}

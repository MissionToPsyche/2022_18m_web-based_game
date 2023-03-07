using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Dialogue
{
    public string name;

    public string[] sentences;

    public Dialogue(string diagTitle, string[] diagBody) {
        name = diagTitle;
        sentences = diagBody;
    }
}

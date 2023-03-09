using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VictoryMessage : MonoBehaviour
{
    public TMPro.TextMeshProUGUI textMeshPro;
    // Start is called before the first frame update
    void Start()
    {
        textMeshPro.text = " ";
    }

    public void display()
    {
        textMeshPro.text = "     Success! \n\n All Wires Fixed!";
    }
}

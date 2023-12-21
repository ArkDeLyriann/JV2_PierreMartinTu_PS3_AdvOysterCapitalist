using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LibraryAssociation : MonoBehaviour
{

    public TextMeshProUGUI oysterText;
    public GameObject panel;
    public TextMeshProUGUI daysText;
    // Start is called before the first frame update
    void Awake()
    {
        Library lbr = FindObjectOfType<Library>();
        lbr.oysterText = oysterText;
        lbr.panel = panel;
        lbr.daysText = daysText;
        
    }
 
}

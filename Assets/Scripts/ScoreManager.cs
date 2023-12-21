using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public Library myLibrary;
    public int myScore;

    public TextMeshProUGUI myText;
    // Start is called before the first frame update
    void Awake()
    {
        myLibrary = FindObjectOfType<Library>();
    }

    

    // Update is called once per frame
    void Update()
    {
        myScore = myLibrary.oysters*10 + myLibrary.money;

        myText.text = "You Scored " + myScore.ToString() + "Try to beat your score next time !" ;
    }


}

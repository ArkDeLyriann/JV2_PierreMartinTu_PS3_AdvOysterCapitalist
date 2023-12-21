using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class Library : MonoBehaviour
{
    public GameObject ThisLibrary;

    public AudioSource audioSource;
    public AudioClip audioClip;

    public bool effectsActive = true;

    public bool soundActive;

    public TextMeshProUGUI oysterText;

    public TextMeshProUGUI daysText;
    public GameObject panel;
    public int nbOfDays = 1;

    // BIBLIOTHEQUE DES VARIABLES
    public int stockLevel = 1;

    public bool hasWonPuzzle=true;
    public int prodLevel =1 ;
    public int money = 200;
    public  int oysters = 0;
    public int numberOfRacks = 0;

    public int daysLeft;
    
    void Awake()
    {
        DontDestroyOnLoad(ThisLibrary);
        effectsActive = true;
        soundActive = true;
    }


    public void AddOyster(int n)
    {
        SetOyster(oysters+n);
    }

    public void SetOyster(int newNumber)
    {
        oysters = newNumber;
        oysterText.text = oysters.ToString("000");
    }

    public int GetOyster()
    {
        return oysters;
    }

    // Gestion des jours de jeu et de fin de partie.
    void Start()
    {
        StartCoroutine(TimeSystem());
    }

    void Update()
    {
        if(!soundActive){
            audioSource.volume = 0;
        }
        else{
            audioSource.volume =0.5f;
        }
        
        if (nbOfDays >= 14)
       {
            GameEnd();
       }
    }


    private IEnumerator TimeSystem()
    {
        yield return new WaitForSeconds(40);

        newDay();
    }

    private IEnumerator FadeOut()
    {
        yield return new WaitForSeconds(2);
        panel.SetActive(false);
        StartCoroutine(TimeSystem());
    }


    public void newDay()
    {
        panel.SetActive(true);
        nbOfDays += 1;
        daysLeft = 14 - nbOfDays;
        daysText.text = "Day " + nbOfDays.ToString("00") + "\n You have" + daysLeft.ToString() + " days left";
        StartCoroutine(FadeOut());
    }

    public void GameEnd()
    {



        SceneManager.LoadScene(4);
    }

    

}

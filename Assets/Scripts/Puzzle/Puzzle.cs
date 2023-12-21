using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Puzzle : MonoBehaviour
{

    public GameObject victoryPanel;

    public GameObject defeatPanel;

    public TextMeshProUGUI timerText;

    public Library myLibrary;

    public GameObject[] puzzlePieces;

    public GameObject[] funFacts;
    public Transform emptySlot;

    public Piece1Checker piece1;
    public Piece2Checker piece2;
    public Piece3Checker piece3;
    public Piece4Checker piece4;
    public Piece5Checker piece5;
    public Piece6Checker piece6;
    public Piece7Checker piece7;
    public Piece8Checker piece8;
    public bool puzzleWon = false;
    private float timer;

    private int thisTimeFact;

    private float timeLeft;
    List<bool> checkList;

    public int correctlyPlacedPiece = 0;
    private GameObject[,] puzzleGrid = new GameObject[3,3];
    // Start is called before the first frame update
    void Start()
    {
        checkList = new List<bool>();
        myLibrary = FindObjectOfType<Library>();
        for (int y=0; y<8; y++){
            checkList.Add(false);
        }

        thisTimeFact = Random.Range(0,4);
        

        Debug.Log(checkList.Count);

        InitializePuzzle();

        piece1 = FindObjectOfType<Piece1Checker>();
        piece2 = FindObjectOfType<Piece2Checker>();
        piece3 = FindObjectOfType<Piece3Checker>();
        piece4 = FindObjectOfType<Piece4Checker>();
        piece5 = FindObjectOfType<Piece5Checker>();
        piece6 = FindObjectOfType<Piece6Checker>();
        piece7 = FindObjectOfType<Piece7Checker>();
        piece8 = FindObjectOfType<Piece8Checker>();

    }

    // Update is called once per frame
    void Update()
    {   
        timer += Time.deltaTime;
        timeLeft = 45-timer;

        if(timeLeft <= 0){
            defeatPanel.SetActive(true);
            StartCoroutine(timeOut());
        }
        
        IsPuzzleSolved();

        if (puzzleWon == true){
            
            victoryPanel.SetActive(true);
            funFacts[thisTimeFact].SetActive(true);
            
            myLibrary.hasWonPuzzle = true;
            StartCoroutine(endGame());
        }

        timerText.text = timeLeft.ToString("00");


    }

    public void InitializePuzzle(){

        int index = 0;
        for (int row = 0; row <3; row ++)
        {
            for (int col = 0; col<3; col++){
            if (index!= 8){
            puzzleGrid[row,col] = Instantiate(puzzlePieces[index], new Vector3(-col, -0.4302368f, row), Quaternion.identity);
            }
            else{
               puzzleGrid[row,col] = Instantiate(puzzlePieces[index], new Vector3(-col, -2, row), Quaternion.identity); 
            }
            index ++;
            }

        }


    }

    public void IsPuzzleSolved(){
        if(piece1.isPlaced==true){
            
            checkList[0] = true;
            } else {
                checkList[0] = false;
            }
        if(piece2.isPlaced==true){
            
            checkList[1] = true;
            } else {
                checkList[1] = false;
            }
        if(piece3.isPlaced==true){
            
            checkList[2] = true;
            } else {
                checkList[2] = false;
            }
        if(piece4.isPlaced==true){
            
            checkList[3] = true;
            } else {
                checkList[3] = false;
            }
        if(piece5.isPlaced==true){
            
            checkList[4] = true;
            } else {
                checkList[4] = false;
            }
        if(piece6.isPlaced==true){
            
            checkList[5] = true;
            } else {
                checkList[5] = false;
            }
        if(piece7.isPlaced==true){
            
            checkList[6] = true;
            } else {
                checkList[6] = false;
            }
        if(piece8.isPlaced==true){
            
            checkList[7] = true;
                } else {
                    checkList[7] = false;
                }

        // if (correctlyPlacedPiece == 8){
        //     puzzleWon = true;
        // }

        int somme = 0;
        foreach (bool truc in checkList){
            if (truc == true) {
                somme++;
            }
        }
        if (somme == checkList.Count) {
            puzzleWon = true;
        }
    }

    private IEnumerator endGame()
    {
        yield return new WaitForSeconds(5);
        ChangeScene(1);
    }

     private IEnumerator timeOut()
    {
        yield return new WaitForSeconds(45);
        Defeat();
    }

    public void ChangeScene(int sceneID)
    {
        print("CLIQUE");
         SceneManager.LoadScene(sceneID);
    }

    public void Defeat(){
        victoryPanel.SetActive(true);
        myLibrary.hasWonPuzzle = false;
        StartCoroutine(endGame());
    }
}

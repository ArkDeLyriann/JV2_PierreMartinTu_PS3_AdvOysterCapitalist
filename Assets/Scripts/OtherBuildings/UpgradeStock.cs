using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpgradeStock : MonoBehaviour
{

    public Library myLibrary;
    private int stockLevel;
    private int price;
    private int money;
    

    void Start()
    {
        myLibrary = FindObjectOfType<Library>();
        stockLevel = myLibrary.stockLevel;
        price = stockLevel*100;
        money = myLibrary.money;
    }

    public void StockUpgrade()
    {
        if(money >= price){
            
            money -= price;
            ChangeScene(3);

            myLibrary.money = money;


            if (myLibrary.hasWonPuzzle){
                stockLevel +=1;
                myLibrary.stockLevel = stockLevel;
                myLibrary.hasWonPuzzle = false;
            }
            
        }


    }
    public void ChangeScene(int sceneID)
    {
        print("CLIQUE");
         SceneManager.LoadScene(sceneID);
    }
}

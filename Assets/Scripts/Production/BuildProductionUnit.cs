using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BuildProductionUnit : MonoBehaviour
{
    public Library varLibrary;

    public TextMeshProUGUI priceTxt;
    private int nbOfRacks;
    private int prodLevel; 
    private int money;
    private int price;
    //public GameObject myObject;
    // Start is called before the first frame update
    void Start()
    {
        varLibrary = FindObjectOfType<Library>();
        nbOfRacks = varLibrary.numberOfRacks;
        prodLevel = varLibrary.prodLevel;
        money = varLibrary.money;
        price = prodLevel * 100;
    }

    void Update(){
        priceTxt.text = price.ToString();
    }


    public void UpgradeProductionUnit()
    {
        if (money>=price){
            money -= price;
            ChangeScene(3);
           
            if (varLibrary.hasWonPuzzle){
                prodLevel +=1;
                varLibrary.hasWonPuzzle = false;
                varLibrary.prodLevel = prodLevel;
            }
          
           varLibrary.money = money;
        }

    }
        public void ChangeScene(int sceneID)
    {
        print("CLIQUE");
         SceneManager.LoadScene(sceneID);
    }


}

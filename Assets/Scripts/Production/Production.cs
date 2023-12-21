using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting.FullSerializer;
using UnityEngine.UIElements;
using System.Data.SqlTypes;
public class Production : MonoBehaviour
{

    
    public float timer;

    public Library varLibrary;
    public Market myMarket;
    public int value;

    public  TextMeshProUGUI oysterTxt;

    private int oysterNumber;

    private int stockage;

    public int production;

    private int money;

    public TextMeshProUGUI priceTxt;

    public TextMeshProUGUI moneyTxt;

    public int price;

    private int gainedMoney;
    // Start is called before the first frame update
    void Start()
    {
        varLibrary = FindObjectOfType<Library>();
        myMarket = FindObjectOfType<Market>();

        price = varLibrary.stockLevel*100;
        stockage =  varLibrary.stockLevel*((1+varLibrary.stockLevel)*100);
        production  = varLibrary.prodLevel;
        money = varLibrary.money;
    }

    // Update is called once per frame
    void Update()
    {   
        production  = varLibrary.prodLevel;
        price = varLibrary.stockLevel*100;
        money = varLibrary.money;
        stockage =  varLibrary.stockLevel*100;


        oysterNumber  = varLibrary.GetOyster();
        timer += Time.deltaTime;    
        if(timer>=0.5f)
        {
            if (oysterNumber < stockage){
                oysterTxt.color = new Color(0f,0f,0f,1);
                oysterNumber += 1+(production-1)*production;
                print(oysterNumber);
                varLibrary.SetOyster(oysterNumber);
                timer = 0f;
            } 
            
            else{
                oysterTxt.color = new Color(1.0f,0.2f,0.2f,1);
            }
        }

        moneyTxt.text = money.ToString();

        priceTxt.text = price.ToString();
    }


    
    public void SellOysters(){
        if(oysterNumber>0){
             
             gainedMoney += value*oysterNumber;

             oysterNumber = 0;
             
             
             varLibrary.money = gainedMoney;
        }

    }





}

    

    


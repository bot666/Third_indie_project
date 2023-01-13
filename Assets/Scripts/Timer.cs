using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public bool isActive;
    public float timerValue;
    public float finalValue;
    public int dot;
    public int line;
     
     [SerializeField]TextMeshProUGUI getMorse;
     [SerializeField]TextMeshProUGUI getWord;
     [SerializeField] float spaceDelay = 10f;
     [SerializeField] Button spaceButton; 
     ColorBlock theColor;

    public string[] alphabet = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N",
    "O","P","Q","R","S","T","U","V","W","X","Y","Z","0","1","2","3","4","5","6","7","8","9"};
   public string[] hasan ={".-","-...","-.-.","-..",".","..-.","--.","....","..",".---",
    //10     //11 //12 //13 //14  //15   //16   //17  //18 //19  //20 //21   //22  //23
    "-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-",
    //24    //25
    "-.--","--..",
    //26     //27    //28    //29    //30    //31    //32   //33     //34      //35
    "-----",".----","..---","...--","....-",".....","-....","--...","---..","----."};

    public string currentMorse;
    void start()
    {
        spaceButton = GetComponent<Button>();
        theColor = GetComponent<Button>().colors;
    }

    
    
    void Update()
    {
        getNumber();
        
    }
    void  getNumber()
    {
        
                                                  //0   //1    //2    //3  //4  //5    //6    //7  //8   //9

        if (Input.GetKey(KeyCode.Space))
        {
            timerValue += Time.deltaTime;
            theColor.normalColor = new Color32(133,133,133,133);
            theColor.highlightedColor = new Color32(176,176,176,255);
            theColor.pressedColor = new Color32(176,176,176,255);
            theColor.pressedColor = new Color32(176,176,176,255);
            theColor.selectedColor = new Color32(176,176,176,255);
            theColor.disabledColor = new Color32(255,255,255,100);
            theColor.colorMultiplier = 1;
            theColor.fadeDuration = 0.15f;
            spaceButton.colors = theColor;

        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            finalValue = timerValue;
            timerValue = 0;
            theColor.normalColor = new Color32(255,255,255,255);
            theColor.highlightedColor = new Color32(176,176,176,255);
            theColor.pressedColor = new Color32(176,176,176,255);
            theColor.pressedColor = new Color32(176,176,176,255);
            theColor.selectedColor = new Color32(176,176,176,255);
            theColor.disabledColor = new Color32(255,255,255,100);
            theColor.colorMultiplier = 1;
            theColor.fadeDuration = 0.15f;
            spaceButton.colors = theColor;
        }
        if (finalValue <= 0.120f && finalValue > 0F)
        {

            finalValue = 0;
            currentMorse += ".";
            getMorse.text += " • ";
            Debug.Log(currentMorse);


        }
        else if (finalValue > 0.130f)
        {
            Debug.Log("-");
            finalValue = 0;
            currentMorse += "-";
            getMorse.text += " — ";
            
        }


             spaceDelay -= Time.deltaTime;
            


        
        if ( hasan.Contains(currentMorse))
        {
                int pos = Array.IndexOf(hasan, currentMorse);
                string number = alphabet[pos];
            //getMorse.text = currentMorse;
            if ( Input.GetKeyDown(KeyCode.E))
                {

                Debug.Log(number);
                Debug.Log(currentMorse);

            }
                
                if( getWord.text == number)
                {
                    getWord.color = new Color32(9,200,9,255);
                    spaceDelay = 10;
                }
                else if(getWord.text != number && spaceDelay < 6)
                {
                    getWord.color = new Color32(205,9,9,255);
                    spaceDelay = 10;
                }
        }

     // int pos = Array.IndexOf(hasan, currentMorse);
     // string number = alphabet[pos];
     // if ( Input.GetKeyDown(KeyCode.E) && hasan.Contains(currentMorse))
     // {

     //   //string number = alphabet[pos];
     //   Debug.Log(number);
     //   Debug.Log(currentMorse);
     //    

     //     
     // }


        if (Input.GetKeyDown(KeyCode.R))
        {
            currentMorse = "";
            getMorse.text = "";
            spaceDelay = 10;


        }

        
    }
    
}
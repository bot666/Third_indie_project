using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
public class Timer : MonoBehaviour
{

    public bool isActive;
    public float timerValue;
    public float finalValue;
    public int dot;
    public int line;

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


        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            finalValue = timerValue;
            timerValue = 0;

        }
        if (finalValue <= 0.120f && finalValue > 0F)
        {

            finalValue = 0;
            currentMorse += ".";
            Debug.Log(currentMorse);


        }
        else if (finalValue > 0.130f)
        {
            Debug.Log("-");
            finalValue = 0;
            currentMorse += "-";
        }

            


        
        if (hasan.Contains(currentMorse) && hasan.Length >= 37)
        {
            int pos = Array.IndexOf(hasan, currentMorse);
            string number = alphabet[pos];
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log(number);
                Debug.Log(currentMorse);
            }

            //string number = alphabet[pos];





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

        }

        
    }
    
}

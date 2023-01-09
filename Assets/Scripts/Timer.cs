using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Timer : MonoBehaviour
{
    public bool isActive;
    public float timerValue;
    public float finalValue;
    public int dot;
    public int line;
    public string[] morse = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---",
    "-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-",
    "-.--","--..",
    "-----",".----","..---","...--",".....","-....","--...","---..","----."};
    public string[] alphabet = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N",
    "O","P","Q","R","S","T","U","V","W","X","Y","Z","0","1","2","3","4","5","6","7","8","9"};
    public string currentMorse;


    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            timerValue += Time.deltaTime;


        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            finalValue = timerValue;
            timerValue = 0;
            
        }
        if(finalValue <= 0.120f && finalValue > 0F)
        {
            
            finalValue = 0;
            currentMorse += ".";
            Debug.Log(currentMorse);


        }
        else if (finalValue > 0.130f) 
        {
            Debug.Log("line");
            finalValue = 0;
            currentMorse += "-";
        }

        if (morse.Contains(currentMorse))
        {
            Debug.Log("A");
            currentMorse = "";
        }
        if (morse.Contains(currentMorse))
        {
            Debug.Log("N");
            currentMorse = "";
            
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            currentMorse = "";

        }
        
    }
}

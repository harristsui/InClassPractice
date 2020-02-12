using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    void Start()
    {
        int test = 7;
        print(Double(test));
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            IncreaseScore(2);
        }
    }

    /// <summary>
    /// This increase the score by the amount passed
    /// </summary>
    public bool IncreaseScore(int increaseAmount)
    {
        if(increaseAmount > 0)
        {
            print("increaseScore");
            score += increaseAmount;
            return true;
        } else
        {
            return false;
        }
  
    }

    //this function will double it 
    int Double (int toDouble)
    {
        return toDouble * 2;
    }

    /// <summary>
    /// This returns 1 or 0 depending on the string passed to it
    /// </summary>
    /// <param name="thingtoReturn"> Pass in "one" to get 1 </param>
    /// <returns></returns>
    int OneOrZero(string thingtoReturn)
    {
        if(thingtoReturn == "one")
        {
            return 1;
        } else
        {
            return 0;
        }
    }

    int CheatMode(string cheatCode)
    {
        Debug.Log("cheatActivated");
        return 1;
    }
}

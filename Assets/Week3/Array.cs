using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    public string[] myStringArray;
    public string[] newStringthree;

    List<string> greetings = new List<string>();
    void Start()
    {
        //myStringArray = new string[] { "first Element", "second Element" };

        //random selection from List
        //greetings.Add("oh");
        //greetings.Add("yeah");
        //greetings.Add("hey");
        //Debug.Log(greetings[Random.Range(0, greetings.Count)]);


        //foreach(string t in myStringArray)
        //{
        //    print(t);
        //}

        //for(int i = 0; i < myStringArray.Length; i++)
        //{
        //    print(myStringArray[i]);
        //}

        //List<string> newList = listMaker(3);
        //foreach(string t in newList)
        //{
        //    print(t);
        //}

        //int[] newIntArray = new int[] { 1, 2, 3, 4, 5 };
        //print(lastItemDoubler(newIntArray));
    }
    void Update()
    {

    }

    List<string> listMaker(int callTimes)
    {
        List<string> toreturn = new List<string>();

        for (int i = 0; i < callTimes; i++)
        {
            toreturn.Add("HELLO");
        }
        return toreturn;
    }

    int lastItemDoubler(int[] array)
    {
        return array[array.Length - 1] * 2;
    }
  
}


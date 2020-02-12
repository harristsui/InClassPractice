using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[AddComponentMenu("myScripts / game manager")]
public class GameManagerr : MonoBehaviour
{
    [ContextMenuItem("get a random time", "PickRandomGameLength")] //rightClick to run the function
    [Header("Important game variable")] //header in the inspector 
    [Range(0, 100f)]
    public int gameLength;
    
    //[Space(50)]
    [Header("reference to other scripts")]
    public ScoreManager scoremanager;

    [HideInInspector] public float hideInInspector = 10f; //hide what is public
    [SerializeField] private int showInInspector = 1; //show what is private 

    [Tooltip("playerName")]public string plname; //hover over in the inspector and it shows the description
    void Start()
    {
        scoremanager.IncreaseScore(2);
    }


    void Update()
    {
        
    }

    [ContextMenu("Randomize Time")] //on the settings tab to run the function
    void PickRandomGameLength()
    {
        gameLength = Random.Range(0, 100);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1 : MonoBehaviour

// Double slash means either code from finishline.cs here just in case we need it. Or replacement for own code while we find actual code (or yk like actual notes.)
{
    [SerializeField] public GameObject Puzzle;
    [SerializeField] public GameObject Door;
    //[SerializeField] public bool isGameActive;
    //[SerializeField] public TextMeshProUGUI gameOverText;


    
    void Start()
    {
        //isGameActive = true;
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
{
    if (Puzzle) //???

    Destroy(Door);
    

}

    private void OnTriggerEnter (Collider other)
{
    //if object Puzzle is clicked
    Destroy(Door);
 

}

    //public void GameOver()
   // {
   //     isGameActive = false;
    //    gameOverText.gameObject.SetActive(true);
   // }

}

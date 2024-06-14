using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinishLine : MonoBehaviour
//Double slash means Replacement for own code while we find actual code (or yk like actual notes.)

{
    [SerializeField] public bool isGameActive;

    [SerializeField] public TextMeshProUGUI gameOverText;

      void Start()
    {
        isGameActive = true;
    }

   
    void Update()
    {
        
    }

    public void GameOver()
    {
        //To trigger gameover we want to cross the "finish line" but how do we code that on here?
        isGameActive = false;
        gameOverText.gameObject.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour

    
{
    public enum GameState
    {
        PREPARATION,
        RUNNING,
        END,
    }



    public static GameManager instance { get; set; } = null;


    private GameState gameState { get; set; } = GameState.PREPARATION;




    private float gameTimer { get; set; } = 0;
    private const float preparationTime = 10;

    public int gold { get; set; } = 10; 



    private void Awake()
    {
        instance = this;
    }


    void Start()
    {
        gameTimer = preparationTime;
    }

   
    void Update()
    {
        switch(gameState)
        {
            case GameState.PREPARATION:
                gameTimer -= Time.deltaTime;
                UIManager.instance.SetTimer(gameTimer);
                if(gameTimer <= 0)
                {
                    gameTimer = preparationTime;
                    gameState = GameState.RUNNING;

                }
                break;
            case GameState.RUNNING:
                break;
            case GameState.END:
                break;

        }
    }

    public void addGold(int value)
    {
        gold += value;
        UIManager.instance.SetGold(gold);
    }
}

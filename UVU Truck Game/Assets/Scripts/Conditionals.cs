using System;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    public int a, b, c;
    public string password;
    public bool canEnter;
    
    public enum GameStates
    {
        Starting, Playing, Ending 
    }

    public GameStates currentGameState;
    
    void Start()
    {
        switch (currentGameState)
        {
            case GameStates.Starting:
                print("Starting");
                break;
            case GameStates.Playing:
                print("Playing");
                break;
            case GameStates.Ending:
                print("Ending");
                break;
            default:
                print("Nothing");
                break;
        }

        switch (password)
        {
            case "OU812":
                print("Correct");
                break;
            case "ImBatman":
                print("You are Batman");
                break;
            default:
                print("Incorrect");
                break;
        }

        if (a + b != c)
        {
            print(true);
        }
        else
        {
            print(false);
        }

        if (password != "OU812")
        {
            print("Correct");
        }
        else
        {
            print("Incorrect");
        }

        if (!canEnter)
        {
            print("Welcome");
        }
        else
        {
            print("Go Away!");
        }
    }
}
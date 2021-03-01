using System;
using System.Collections;
using UnityEngine;

public class LoopBehaviour : MonoBehaviour
{
    public string[] playerNames;
    
    private IEnumerator Start()
    {
        foreach (var playerName in playerNames)
        {
            print(playerName);
        }

        while (true)
        {
            yield return new WaitForSeconds(1);
            print("Hello");
        }
    }
}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerVeggie : MonoBehaviour
{
    private string _myName;

    void Start()
    {
        var allPlayers = FindObjectsOfType<PlayerVeggie>();

        foreach (var aPlayer in allPlayers)
        {
            Debug.Log($"{aPlayer} is active with ID: {aPlayer.GetInstanceID()} ({allPlayers.Length})");
        }
        _myName = $"PLAYER_{Math.Abs(GetInstanceID())}";
    }
    

    private void OnMove(InputValue value)
    {
        var dv = value.Get<Vector2>();
        if (dv.x == 0 && dv.y == 0) return;
        transform.Translate(dv.x, dv.y, 0);
        Debug.Log($"{_myName}: OnMove {dv.x},{dv.y}");
    }
   
}

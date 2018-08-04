﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
    
public class GameManager : MonoBehaviour {

    private BoardManager boardScript;
    private int level = 3;

    void Awake() {
        boardScript = GetComponent<BoardManager>();
        InitGame();
    }
    
	void InitGame() {
        boardScript.SetupScene(level);
    }
    
	void Update() {
            
    }

}
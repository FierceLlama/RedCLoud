﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {

	
    public void RestartScene()
    {
        SceneManager.LoadScene("Prototype scene");
    }
}

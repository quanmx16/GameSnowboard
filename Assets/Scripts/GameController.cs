using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController instance;
    public static int Level = 0;
    public TMP_Text totalScoreText;

    void Start()
    {

    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance == this)
        {
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        //if (timer.Finished)
        //{
        //    SceneManager.LoadScene("Scence02");
        //}
        //else
        //{
        //    int remainTime = gameTime - (int)Math.Ceiling(timer.GetElapsedTime());
        //    clock.text = "" + remainTime;
        //}
    }
}

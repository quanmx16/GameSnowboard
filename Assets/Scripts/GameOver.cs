using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TMP_Text LevelText;
    // Start is called before the first frame update
    void Start()
    {
        LevelText.text = "You passed " + GameController.Level + " level(s)!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

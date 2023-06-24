using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    [SerializeField] float delayTime = 2f;
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            GameController.Level += 1;
            if(GameController.Level > 0 && GameController.Level < 5)
            {
                SceneManager.LoadScene("Level" + (GameController.Level + 1));
            }
            else
            {
                SceneManager.LoadScene("GameOver");
            }
            Debug.Log("You Finished!");
            //Invoke("ReloadScene", delayTime); // Invoke has to use a method that you are delaying
        }
    }

    //void ReloadScene() //Created reload scene method in order to use invoke
    //{
    //    SceneManager.LoadScene(0);
    //}


}

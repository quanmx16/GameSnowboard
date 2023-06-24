using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{

    [SerializeField] float delayTime = 1f;


    bool hasCrashed = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        //if(other.tag =="Ground" && !hasCrashed)
        //{
        //hasCrashed = true;
        //FindObjectOfType<PlayerController>().DisableControls();
        Debug.Log("Ouch!");
        Invoke("ReloadScene", delayTime);
        //}
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}

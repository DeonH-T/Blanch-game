using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinish : MonoBehaviour
{
    private AudioSource finishnoise;
// so that the level finish noise will only play once by changing the value to true once the level is complete
    private bool levelCompleted = false; 
    
    private void Start()
    {
        finishnoise = GetComponent<AudioSource>(); 
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Character" && !levelCompleted)
        {
            finishnoise.Play();
            levelCompleted = true;
            // invoke creates a delay so that the level finish sound effect can play
            Invoke("CompleteLevel", 2f);
        }
    }
// this loads the level with a value of 1 higher than the current scene from the scene index
    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

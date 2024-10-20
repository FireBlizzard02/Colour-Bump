using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    // AdManager adManager = FindObjectOfType<AdManager>();
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player")
        {
            LevelFinished();
        }
    }

    private void LevelFinished(){
        Debug.Log("Congratulations , You have fineshed the level.");
        // NextLevel = SceneManager.GetActiveScene().buildIndex + 1;
        OnFinish();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        // if (SceneManager.GetActiveScene().buildIndex == 1);
        // {
        //     FindObjectOfType<AdManager>().ShowInterstitial();
        // }
    }
    public void OnFinish()
    {
        // Find the AdManager in the scene
        AdManager adManager = FindObjectOfType<AdManager>();

        // Check if AdManager exists and call the ShowInterstitial method
        if (adManager != null)
        {
            adManager.ShowInterstitial();
        }
        else
        {
            Debug.LogError("AdManager not found in the scene!");
        }
    }
}

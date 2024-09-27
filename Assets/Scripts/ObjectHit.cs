using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectHit : MonoBehaviour
{
    private bool isGameOver = false;

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Player" && !isGameOver)
        {
            GameOver();
        }
    }

    private void GameOver()
    {
        isGameOver = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

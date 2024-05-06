using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;
public class GameOverBehaviour : MonoBehaviour
{

    public void LaunchGame()
    {
        SceneManager.LoadScene("Level");
        GameManager.Instance.SetIsPlaying(true);
        GameManager.Instance.SetScore(0);
    }
}

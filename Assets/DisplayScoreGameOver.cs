using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class DisplayScoreGameOver : MonoBehaviour
{
    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = $"Score : {GameManager.Instance.GetScore()}";
    }
}

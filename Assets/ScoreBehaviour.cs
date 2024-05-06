using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBehaviour : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D trigger2D)
    {
        if (trigger2D.CompareTag("Player"))
        {
            GameManager.Instance.AddScore();
        }
    }

}

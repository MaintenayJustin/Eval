using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
// Ce gameManager va se charger entre autre de faire spawner des pipes
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public TMP_Text ScoreText;
    private GameObject Canvas;
    public float TimeBetweenSpawn = 1.5f;
    private float time = 0f;
    public GameObject Pipe;
    public float height;
    public int score;
    public bool _isPlaying;

    private void Awake()
    {
        // Si jamais on charge une deuxième scène avec 
        // un autre game manager
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);

    }
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (_isPlaying)
        {

            Canvas = GameObject.Find("Canvas");
            ScoreText = Canvas.GetComponentInChildren<TMP_Text>();

            if (time > TimeBetweenSpawn)
            {
                // Transform.position étant un Vecteur3, on doit lui ajouter un Vecteur3 avec un z nul
                Vector3 vecteurAAJouter = new Vector3(0, Random.Range(-height, height + 0.5f), 0);
                // On crée un nouveau pipe
                GameObject newPipe = Instantiate(Pipe, vecteurAAJouter, Quaternion.identity);
                // On place le nouveau pipe dans une hauteur aléatoire

                // On remet le chronomètre à 0
                time = 0;
                // On détruit l'objet au bout de 10 secondes
                Destroy(newPipe, 6);
            }
            time += Time.deltaTime;
        }
    }
    public void AddScore()
    {
        ScoreText.text = $"{++score}";
    }
    public void SetIsPlaying(bool newState)
    {
        _isPlaying = newState;
    }
    public void SetScore(int newScore)
    {
        score = newScore;
    }
    public void Die()
    {
        SceneManager.LoadScene("Retry");

        _isPlaying = false;
    }
    public int GetScore()
    {
        return score;
    }
    public void LaunchGame()
    {
        SceneManager.LoadScene("Level");
        GameManager.Instance.SetIsPlaying(true);
    }
}

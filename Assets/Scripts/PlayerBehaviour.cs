using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour
{
    public Rigidbody2D rigidBody;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {
        // On lance le bonhomme au début de la partie
        rigidBody.velocity = Vector2.up * jumpForce * 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        // On fait sauter le petit oiseau à chaque qu'on clique
        if (Input.GetMouseButtonDown(0))
        {
            rigidBody.velocity = Vector2.up * jumpForce;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingObjects : MonoBehaviour
{
    public float speed;
    private Vector2 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * speed);
    }
}

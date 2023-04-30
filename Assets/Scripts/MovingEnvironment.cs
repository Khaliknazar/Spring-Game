using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnvironment : MonoBehaviour
{
    static float moveSpeed = 5f;

    private void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
        moveSpeed += Time.deltaTime / 60f;
    }
}

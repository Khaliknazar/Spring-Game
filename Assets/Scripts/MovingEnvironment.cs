using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEnvironment : MonoBehaviour
{
    public static float moveSpeed = 5f;

    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSpeed : MonoBehaviour
{
    [SerializeField] ScoreController scoreController;
    [SerializeField] float Level2;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (scoreController.score > Level2)
        {
            MovingEnvironment.moveSpeed = 6f;
        }
    }
}

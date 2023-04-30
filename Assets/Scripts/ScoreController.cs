using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] float scoreSpeed;
    float score;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString("F0");
        score += Time.deltaTime * scoreSpeed;
    }
}

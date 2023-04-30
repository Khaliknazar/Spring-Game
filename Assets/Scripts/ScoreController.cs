using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text recordText;
    [SerializeField] float scoreSpeed;
    [HideInInspector] public float score;
    float record;

    void Start()
    {
        record = PlayerPrefs.GetFloat("Record");
    }

    void Update()
    {
        scoreText.text = score.ToString("F0");
        recordText.text = record.ToString("F0");
        score += Time.deltaTime * scoreSpeed;
        if (score > record)
        {
            PlayerPrefs.SetFloat("Record", score);
        }
    }
}

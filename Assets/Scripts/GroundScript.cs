using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{
    [SerializeField] float startPos;
    [SerializeField] float deathPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x <= deathPos)
        {
            transform.position = new Vector2(startPos, transform.position.y);
        }
    }
}

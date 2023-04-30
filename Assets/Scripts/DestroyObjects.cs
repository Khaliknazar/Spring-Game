using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjects : MonoBehaviour
{
    void Update()
    {
        if (transform.position.x <= -10f)
        {
            Destroy(gameObject);
        }
    }
}

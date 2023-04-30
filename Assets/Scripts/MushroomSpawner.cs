using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomSpawner : MonoBehaviour
{
    [SerializeField] GameObject mushroom_prefab;
    Vector2 mousePos()
    {
        Vector2 mousePoition = Input.mousePosition;
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(mousePoition);

        RaycastHit2D hit = Physics2D.Raycast(worldPos, Vector2.down);
        return new Vector2(hit.point.x, hit.point.y);
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MushroomSpawn();
        }
    }

    void MushroomSpawn()
    {
        Instantiate(mushroom_prefab, mousePos(), Quaternion.identity);
    }
}

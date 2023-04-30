using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomSpawner : MonoBehaviour
{
    [SerializeField] GameObject mushroom_prefab;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] float reloadTime;
    bool isReady = true;
    Vector2 mousePos()
    {
        Vector2 mousePoition = Input.mousePosition;
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(mousePoition);

        RaycastHit2D hit = Physics2D.Raycast(worldPos, Vector2.down, Mathf.Infinity, groundLayer);
        return new Vector2(hit.point.x, hit.point.y + 0.2f);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isReady)
        {
            MushroomSpawn();
        }
    }

    void MushroomSpawn()
    {
        Instantiate(mushroom_prefab, mousePos(), Quaternion.identity);
        isReady = false;
        StartCoroutine(Realoading());
    }

    IEnumerator Realoading()
    {
        yield return new WaitForSeconds(reloadTime);
        isReady = true;
    }
}

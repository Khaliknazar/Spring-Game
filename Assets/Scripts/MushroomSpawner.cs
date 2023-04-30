using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomSpawner : MonoBehaviour
{
    [SerializeField] AudioClip mushroomSound;
    [SerializeField] GameObject[] mushroom_prefabs;
    [SerializeField] LayerMask groundLayer;
    [SerializeField] float reloadTime;
    AudioSource audioSource;
    bool isReady = true;

    Vector2 mousePos()
    {
        Vector2 mousePoition = Input.mousePosition;
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(mousePoition);

        RaycastHit2D hit = Physics2D.Raycast(worldPos, Vector2.down, Mathf.Infinity, groundLayer);
        return new Vector2(hit.point.x, hit.point.y + 0.2f);
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isReady && Check())
        {
            MushroomSpawn();
        }
    }

    void MushroomSpawn()
    {
        Instantiate(mushroom_prefabs[Random.Range(0, mushroom_prefabs.Length)], mousePos(), Quaternion.identity);
        audioSource.pitch = Random.Range(0.9f, 1.2f);
        audioSource.PlayOneShot(mushroomSound);
        isReady = false;
        StartCoroutine(Realoading());
    }

    IEnumerator Realoading()
    {
        yield return new WaitForSeconds(reloadTime);
        isReady = true;
    }

    bool Check()
    {
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Physics2D.Raycast(worldPos, Vector2.zero, Mathf.Infinity, groundLayer).collider) return false;
        return true;
    }
}

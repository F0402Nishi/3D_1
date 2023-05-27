using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] staclePrefab;//��Q���v���n�u
    Vector3 spawnPos = new Vector3(25,0,0);//�X�|�[������ꏊ
    float elapsedTime;
    [SerializeField] float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if(elapsedTime > 2.0f) 
        {
            SpawnRandomObject();
            elapsedTime = 0.0f;
        }
    }
    void SpawnRandomObject()
    {
        int ObjectIndex = Random.Range(0, staclePrefab.Length);
        Instantiate(staclePrefab[ObjectIndex], new Vector3(25, 0, 0), staclePrefab[ObjectIndex].transform.rotation);
    }
}

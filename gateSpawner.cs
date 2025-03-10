using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gateSpawner : MonoBehaviour
{

    public float maxTime = 1;
    private float timer = 0;
    public GameObject gate;
    public float height;

    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newGate = Instantiate(gate);
            newGate.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newGate, 5); 
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject[] SpawnObject;
    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    void SpawnObjects()
    {
        int i = Random.Range(0, 3);
        PositionY = Random.Range(6, -4f);
        this.transform.position = new Vector3(15, PositionY, transform.position.z);
        Instantiate(SpawnObject[i], transform.position, transform.rotation);
    }
}

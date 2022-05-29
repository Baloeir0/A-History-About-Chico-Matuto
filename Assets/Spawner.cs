using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ObjectSpawn;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ObjectSpawn, transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            spawnDog();
        }
    }
    void spawnDog ()
    {
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheDrop3 : MonoBehaviour
{
    public GameObject gameObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetButtonDown("Fire3"))
        {
            SpawnIt();
        } 
    }

    void SpawnIt()
    {
        Instantiate(gameObj, transform.position, Quaternion.identity);
    }
}

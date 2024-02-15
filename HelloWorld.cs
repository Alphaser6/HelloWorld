using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int number = 0;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello, World");
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        print("crickets"); 
    }
}

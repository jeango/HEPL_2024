using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    public string Message;
    // Start is called before the first frame update
    void Start()
    {
        print("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        print(Message);
    }
}

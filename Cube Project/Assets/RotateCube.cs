using System;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public Transform Cube;
    public Vector3 turn;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a") && Input.GetKeyUp("a"))
        {
            Debug.Log("here");
            
            Cube.transform.Rotate(0, 90 * Time.deltaTime, 0);
        }
        //Cube.transform.Rotate(0, 90 * Time.deltaTime, 0);
    }
}

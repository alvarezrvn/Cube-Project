using System;
using UnityEngine;

public class RotateCube : MonoBehaviour
{
    public Transform Cube;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            Debug.Log("here");

            Cube.transform.Rotate(0, 90 * Time.deltaTime * 15, 0);
        }
        if (Input.GetKeyDown("d"))
        {
            Debug.Log("here");

            Cube.transform.Rotate(0, -90 * Time.deltaTime * 15, 0);
        }
        if (Input.GetKeyDown("w"))
        {

            Cube.transform.Rotate(-90 * Time.deltaTime * 15, 0, 0);
        }
        if (Input.GetKeyDown("s"))
        {
            Debug.Log("here");

            Cube.transform.Rotate(90 * Time.deltaTime * 15, 0, 0);
        }
    }
}

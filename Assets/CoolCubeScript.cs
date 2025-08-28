using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolCubeScript : MonoBehaviour
{
    private float update;

    void Awake()
    {
        Debug.Log("Awake");
        update = 0.0f;
    }

    IEnumerator Start()
    {
        Debug.Log("Start1");
        yield return new WaitForSeconds(2.5f);
        Debug.Log("Start2");
    }

    void Update()
    {
        // update += Time.deltaTime;
        // if (update > 1.0f)
        // {
            // update = 0.0f;
            Debug.Log("Update");
        // }
    }
}

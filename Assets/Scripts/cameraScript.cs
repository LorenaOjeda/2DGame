using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraScript : MonoBehaviour
{

    public GameObject cosmicMan;

    void Update()
    {
        Vector3 position = transform.position;
        position.x = cosmicMan.transform.position.x;
        transform.position = position;
    }
}

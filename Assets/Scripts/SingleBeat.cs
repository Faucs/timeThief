using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleBeat : MonoBehaviour
{
    public float maxT = 0f;
    public float travelTime = 1.6f;
    private float currT = 0.0f;
    private float distanceAB = 14.0f;
    private float spawnPointX = 7.0f;
    private float spawnPointY = 0.0f;
    private float spawnPointZ = 0.0f;

    // Update is called once per frame
    void Update()
    {
        if (currT >maxT)
        {
            Destroy(gameObject);
        }
        currT += (float) Time.deltaTime;
        transform.localPosition = new Vector3(-currT*distanceAB/travelTime + spawnPointX, spawnPointY, spawnPointZ); //debe demorar 1.6 seg entre el punto a y b v
    }
}
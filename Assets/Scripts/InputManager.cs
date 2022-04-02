using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public ConnectionPlacer cp;
    public BucketPlacer bp;

    public void Update()
    {
        //Cancel bucket placement
        if (bp.placingBucket && Input.GetMouseButtonDown(1))
        {
            bp.StopPlacingBucket();
        }
        //Cancel connection placement
        else if (cp.placingConnection && Input.GetMouseButtonDown(1))
        {
            cp.StopPlacingConnection();
        }
        //Start bucket placement
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (cp.placingConnection)
                cp.StopPlacingConnection();
            if (!bp.placingBucket)
                bp.StartPlacingBucket();
        }
        //Start connection placement
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (bp.placingBucket)
                bp.StopPlacingBucket();
            if (!cp.placingConnection)
                cp.StartPlacingConnection();
        }
    }
}
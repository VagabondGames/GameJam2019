using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class GameEngine : MonoBehaviour {

    public bool isTrackingDisabled = true;
    public bool isMovementNegated = false;
    public bool isRotationNegated = false;

    // Use this for initialization
    void Start ()
    {
        UnityEngine.XR.InputTracking.disablePositionalTracking = isTrackingDisabled;
    }

    // Update is called once per frame
    void Update()
    {
        if (isMovementNegated)
        {
            Vector3 verticalCameraMovement = new Vector3 (-InputTracking.GetLocalPosition(XRNode.CenterEye).x, 0, -InputTracking.GetLocalPosition(XRNode.CenterEye).z);

            transform.position = verticalCameraMovement;

            //transform.position = -InputTracking.GetLocalPosition(XRNode.CenterEye);
        }

        if (isRotationNegated)
            transform.rotation = Quaternion.Inverse(InputTracking.GetLocalRotation(XRNode.CenterEye));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Camera CameraTopView;
    public Camera cameraFPSView;
    // Start is called before the first frame update
    void Start()
    {
        cameraTopView = Camera.main;
        CameraTopView.enabled = true;
        CameraTopView.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C)) {
            CameraTopView.enabled = !CameraTopView.enabled;
            CameraFPSView.enabled = !cameraFPSView.enabled;

        }
        
    }
}

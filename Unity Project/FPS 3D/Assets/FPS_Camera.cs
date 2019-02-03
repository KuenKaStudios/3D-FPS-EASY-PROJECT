using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPS_Camera : MonoBehaviour
{
    public Camera FPS_mCam;

    public float hSpeed;
    public float vSpeed;

    private float h;
    private float v;

    private void Awake()
    {
        if (FPS_mCam == null)
        {
            FPS_mCam = Camera.main;
        }
    }
    // Update is called once per frame
    void Update()
    {
        h = hSpeed * Input.GetAxis("Mouse X");
        v = vSpeed * Input.GetAxis("Mouse Y");

        transform.Rotate(0.0f, h, 0.0f);
        FPS_mCam.transform.Rotate(v * -1, 0.0f, 0.0f);

    }
}

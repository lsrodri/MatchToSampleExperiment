using UnityEngine;

public class CustomCameraRender : MonoBehaviour
{
    public Camera recordingCamera;
    public float targetFrameRate = 29.97f;

    private float nextFrameTime = 0f;

    void Start()
    {

        Time.timeScale = 1f; // Ensure normal time progression


        if (recordingCamera == null)
        {
            recordingCamera = GetComponent<Camera>();
        }

        nextFrameTime = Time.time;



    }

    void Update()
    {
        if (Time.time >= nextFrameTime)
        {
            recordingCamera.Render();
            nextFrameTime += 1f / targetFrameRate;
        }
    }
}

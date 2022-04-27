using System;
using System.Collections;

using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ImageTrackingExample : MonoBehaviour
{
    ARTrackedImageManager aRTrackedImageManager;
    [SerializeField] TMPro.TextMeshProUGUI text;
    private void Awake()
    {
        aRTrackedImageManager = this.GetComponent<ARTrackedImageManager>();
        text.text = "Initializing...";
    }

    void Start()
    {
        aRTrackedImageManager.trackedImagesChanged += onImageChanged;
    }

    private void onImageChanged(ARTrackedImagesChangedEventArgs obj)
    {
        foreach(var trackedImg in obj.added)
        {
            Debug.Log(trackedImg.name);
            text.text = trackedImg.name;
        }
    }

    private void OnDestroy()
    {
        aRTrackedImageManager.trackedImagesChanged -= onImageChanged;
    }

    void Update()
    {
        
    }
}

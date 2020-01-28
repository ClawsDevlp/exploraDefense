using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ZXing;
using ZXing.QrCode;
using System;

public class QRCodeHandler : MonoBehaviour
{
    private WebCamTexture camTexture;
    private Rect screenRect;
    public Image thisPage;
    public Image newPage;
    private bool useGui = true;
    IBarcodeReader barcodeReader;
    
    public Quaternion baseRotation;

    void Start() {
        screenRect = new Rect(0, 0, Screen.width, Screen.height);
        camTexture = new WebCamTexture();
        camTexture.requestedHeight = Screen.height;
        camTexture.requestedWidth = Screen.width;
        
        baseRotation = transform.rotation;
        if (camTexture != null) {
            camTexture.Play();
        }
    }

    void OnGUI () {
        if(useGui){
            // drawing the camera on screen
        transform.rotation = baseRotation * Quaternion.AngleAxis(camTexture.videoRotationAngle, Vector3.up);
            GUI.DrawTexture(screenRect, camTexture, ScaleMode.ScaleToFit);
            // do the reading — you might want to attempt to read less often than you draw on the screen for performance sake
            try {
                barcodeReader = new BarcodeReader ();
                // decode the current frame
                var result = barcodeReader.Decode(camTexture.GetPixels32(), camTexture.width , camTexture.height);
                if (result != null) {
                    if(result.Text == "https://equipeludique.fr/nos-jeux/"){    
                        stopAll();
                    }
                }
            } catch(Exception ex) { Debug.LogWarning (ex.Message); }
        }
    }

    void stopAll() {
        camTexture.Stop();
        useGui = false;
        barcodeReader = null;
        camTexture = null;
        GetComponent<UIHandler>().changePage(newPage);
        thisPage.gameObject.SetActive(false);
    }
}

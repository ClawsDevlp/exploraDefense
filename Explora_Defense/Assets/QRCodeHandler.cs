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
    public Image newPage;
    private bool useGui = true;

    void Start() {
        screenRect = new Rect(0, 0, Screen.width, Screen.height);
        camTexture = new WebCamTexture();
        camTexture.requestedHeight = Screen.height;
        camTexture.requestedWidth = Screen.width;
        if (camTexture != null) {
            camTexture.Play();
        }
    }

    void OnGUI () {
        if(useGui){
            // drawing the camera on screen
            GUI.DrawTexture (screenRect, camTexture, ScaleMode.ScaleToFit);
            // do the reading — you might want to attempt to read less often than you draw on the screen for performance sake
            try {
                IBarcodeReader barcodeReader = new BarcodeReader ();
                // decode the current frame
                var result = barcodeReader.Decode(camTexture.GetPixels32(), camTexture.width , camTexture.height);
                if (result != null) {
                    if(result.Text == "https://equipeludique.fr/nos-jeux/"){
                        useGui = false;
                        GetComponent<UIHandler>().changePage(newPage);
                    }
                }
            } catch(Exception ex) { Debug.LogWarning (ex.Message); }
        }
    }
}

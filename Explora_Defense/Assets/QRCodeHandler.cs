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
    IBarcodeReader barcodeReader;
    private Vector3 baseRotation;
    private float speed = 0.1f; 
    private Result result;

    void Start() {
        screenRect = new Rect(0, 0, Screen.width, Screen.height);
        camTexture = new WebCamTexture();
        camTexture.requestedHeight = Screen.height;
        camTexture.requestedWidth = Screen.width;
        baseRotation = transform.eulerAngles;
        
        if (camTexture != null) {
            camTexture.Play();
        }

        StartCoroutine(ReadQR());
    }

    void Update() {
        transform.eulerAngles = new Vector3(
            baseRotation.x,
            baseRotation.y,
            baseRotation.z - camTexture.videoRotationAngle);
        GetComponent<RawImage>().texture = camTexture;
    }

    IEnumerator ReadQR() {
        for(;;) {
            try {
                barcodeReader = new BarcodeReader ();
                // decode the current frame
                result = barcodeReader.Decode(camTexture.GetPixels32(), camTexture.width , camTexture.height);
            } catch(Exception ex) { Debug.LogWarning (ex.Message); yield break; }
            if (result != null) {
                if(result.Text == "https://equipeludique.fr/nos-jeux/"){
                    stopAll();
                    yield return new WaitForSeconds(speed);
                    break;
                }
            }
            yield return new WaitForSeconds(speed);
        }
    }

    void stopAll() {
        camTexture.Stop();
        barcodeReader = null;
        camTexture = null;
        GetComponent<UIHandler>().changePage(newPage);
        thisPage.gameObject.SetActive(false);
    }
}

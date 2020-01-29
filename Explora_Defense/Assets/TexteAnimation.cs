 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TexteAnimation : MonoBehaviour
{
    public float speed = 0.9f;
    public Text fullText;
    public string sentence;
    private Text currentText;

    void Start()
    {
        StartCoroutine(Type());
    }
    IEnumerator Type()
    {
        foreach(char letter in sentence.ToCharArray() )
        {
            fullText.text += letter;
            yield return new WaitForSeconds(speed);
        }
    }

    
}

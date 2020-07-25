using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Getting_Data : MonoBehaviour
{
    public string url = "http://172.20.10.9/ ";
    public Text bpm;
    public void open()
    {

        StartCoroutine(GetRequest(url));

    }

    IEnumerator GetRequest(string uri)
    {

        while (true)
        {
            using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))
            {

                // Request and wait for the desired page.
                yield return webRequest.SendWebRequest();
                bpm.text = webRequest.downloadHandler.text;
                Debug.Log(webRequest.downloadHandler.text);
                yield return new WaitForSeconds(1);


            }

        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class GETrequest : MonoBehaviour
{


    private Text myText;
    // Start is called before the first frame update
    void Start()
    {
        myText = GameObject.Find("leText").GetComponent<Text>();
        StartCoroutine(getRequest_("http://172.16.51.3:5000/select?table=prueba"));
    }


    IEnumerator getRequest_(string uri)
    {
        UnityWebRequest uwr = UnityWebRequest.Get(uri);
        yield return uwr.SendWebRequest();

        if (uwr.isNetworkError)
        {
            Debug.Log("Error While Sending: " + uwr.error);
        }
        else
        {
            Debug.Log("Received: " + uwr.downloadHandler.text);
            myText.text = uwr.downloadHandler.text;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using UnityEngine;

public class HttpUtil {

public delegate void ProcessJson(string json); 

public IEnumerator getHttpDataJson(string url, ProcessJson method)
    {
        var encoding = new System.Text.UTF8Encoding();
        var request = new WWW(url);
        yield return request;
        if (request.error != null)
        {
            Debug.Log("Error:" + request.error);
        }
        else
        {
			string json = request.text;
			method(json);
			Debug.Log(json);
            Debug.Log("Success");
        }

    }
}

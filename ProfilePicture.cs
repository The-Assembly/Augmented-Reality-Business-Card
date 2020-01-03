using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

/*Use the following website for Facebook ID:
 * https://findmyfbid.in
 */

public class ProfilePicture : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(GetTexture());
    }

    IEnumerator GetTexture()
    {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture("http://graph.facebook.com/4/picture?type=large");
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            Texture myTexture = ((DownloadHandlerTexture)www.downloadHandler).texture;
            GetComponent<Renderer>().material.mainTexture = myTexture;
        }
    }
}
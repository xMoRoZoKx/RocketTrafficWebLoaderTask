using System;
using System.Collections;
using System.Collections.Generic;
using Tools;
using UnityEngine;

public class PageLoader
{
    public static IEnumerator Load(string url, Action<PageData> onLoaded, string header, string key)
    {
        string json = "";
        yield return WebLoader.LoadText(url, loadedText => json = loadedText, request =>
        {
            request.SetRequestHeader("Authorization", key);
            request.SetRequestHeader("Authorization", header);
            request.SetRequestHeader("accept", "application/json");
        });
        onLoaded(JsonUtility.FromJson<PageData>(json));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class PageData
{
    public int page;
    public Result[] results;
}
[System.Serializable]
public class Result
{
    public bool adult;
    public string backdrop_patch;
    public int[] genre_ids;
    public int id;
    public string original_language;
    public string original_title;
    public string overview;
    public float popularity;
    public string poster_path;
    public string release_date;
    public string title;
    public bool video;
    public float vote_average;
    public int vote_count;
}
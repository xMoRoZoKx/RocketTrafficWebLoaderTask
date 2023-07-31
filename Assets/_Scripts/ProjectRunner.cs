using System.Collections;
using System.Collections.Generic;
using Tools;
using UnityEngine;

public class ProjectRunner : MonoBehaviour
{
    private readonly string pageUrl = "https://api.themoviedb.org/3/discover/movie?include_adult=false&include_video=false&language=en-US&page=1&sort_by=popularity.desc";
    private readonly string api_key = "00243336e2f949edba05fc655da4510e";
    private readonly string header = "Bearer eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIwMDI0MzMzNmUyZjk0OWVkYmEwNWZjNjU1ZGE0NTEwZSIsInN1YiI6IjVhYzFjM2IxMGUwYTI2NGE1NzA1NmEwMSIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.uy3Lj5gCGGhxulu3ocPzJVh10f7KE_x1IDSE16CGzKw";
    private void Awake()
    {
        StartCoroutine(PageLoader.Load(pageUrl, data =>
         {
             WindowManager.Instance.Show<PagePresenterScreen>().Present(data, pageUrl);
         }, header, api_key));
    }
}

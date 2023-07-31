using TMPro;
using Tools;
using UnityEngine;
using UnityEngine.UI;

public class PageView : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private TextMeshProUGUI title, overview;
    public void Show(string imgUrl, Result data)
    {
        title.text = data.title;
        overview.text = data.overview;
        StartCoroutine(WebLoader.LoadSprite(imgUrl, sprite => icon.sprite = sprite, true, true, request =>
        {
            request.SetRequestHeader("API_KEY", "00243336e2f949edba05fc655da4510e");
            request.SetRequestHeader("Authorization", "Bearer eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIwMDI0MzMzNmUyZjk0OWVkYmEwNWZjNjU1ZGE0NTEwZSIsInN1YiI6IjVhYzFjM2IxMGUwYTI2NGE1NzA1NmEwMSIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.uy3Lj5gCGGhxulu3ocPzJVh10f7KE_x1IDSE16CGzKw");
            request.SetRequestHeader("accept", "application/json");
        }));
    }
}

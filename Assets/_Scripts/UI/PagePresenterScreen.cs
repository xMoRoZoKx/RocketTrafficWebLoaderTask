using System.Collections;
using System.Collections.Generic;
using TMPro;
using Tools;
using UnityEngine;
using UnityEngine.UI;

public class PagePresenterScreen : WindowBase
{
    [SerializeField] private PageView pageViewPrefab;
    [SerializeField] private RectTransform container;
    public void Present(PageData data)
    {
        Debug.LogError(JsonUtility.ToJson(data));
        data.results.Present(pageViewPrefab, container, (view, data) =>
        {
            view.Show(data);
        });
    }
}
public class PageView : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private TextMeshProUGUI title, overview;
    public void Show(Result data)
    {
        title.text = data.title;
        overview.text = data.overview;
        WebLoader.LoadSprite(data.backdrop_patch, sprite => icon.sprite = sprite);
    }
}

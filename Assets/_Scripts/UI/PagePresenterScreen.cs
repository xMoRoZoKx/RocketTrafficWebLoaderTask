using System.Collections;
using System.Collections.Generic;
using Tools;
using UnityEngine;

public class PagePresenterScreen : WindowBase
{
    [SerializeField] private PageView pageViewPrefab;
    [SerializeField] private RectTransform container;
    public void Present(PageData data, string url)
    {
        data.results.Present(pageViewPrefab, container, (view, data) =>
        {
            view.Show(url + data.backdrop_patch, data);
        });
    }
}

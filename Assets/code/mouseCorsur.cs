using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseCorsur : MonoBehaviour
{
    public Texture2D defaultcorsur, clickablecursor;
    public static mouseCorsur instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void clickable()
    {
        Cursor.SetCursor(clickablecursor, Vector2.zero, CursorMode.Auto);
    }
    public void defualt()
    {
        Cursor.SetCursor(defaultcorsur, Vector2.zero, CursorMode.Auto);
    }
    private void Start()
    {
        defualt();
    }
}

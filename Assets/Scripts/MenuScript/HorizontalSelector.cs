﻿using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

using Object = UnityEngine.Object;

public class HorizontalSelector : MonoBehaviour
{

    public TextMeshProUGUI text;
    public RawImage image;

    public Object defaultobject;
    public List<Object> defaultList = new List<Object>();

    public int index = 0;


    [Serializable]
    public class MapList
    {
        public string MapListName;
        public Texture MapListImage;

    }

    [SerializeField] public List<MapList> ObjectList = new List<MapList>();


    void Start()
    {


        text = transform.Find("Text").GetComponent<TMPro.TextMeshProUGUI>();
   

        // Debug.Log(MapListName.Count);

        transform.Find("ButtonPrevious").GetComponent<Button>().onClick.AddListener(Previous);
        transform.Find("ButtonNext").GetComponent<Button>().onClick.AddListener(Next);

    }

    void Previous()
    {
        if (index == 0)
        {
            index = ObjectList.Count - 1;
        }
        else index--;
        if (transform.Find("Image"))
        {
            image.texture = ObjectList[index].MapListImage;
        }
        text.text = ObjectList[index].MapListName;
    }

    void Next()
    {
        if ((index + 1) >= ObjectList.Count)
        {
            index = 0;
        }
        else index++;
        if (transform.Find("Image"))
        {
            image.texture = ObjectList[index].MapListImage;
        }
        text.text = ObjectList[index].MapListName;
    }
}


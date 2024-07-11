﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ComponentGroup  {
    private int key;

    public int Key
    {
        get
        {
            return key;
        }
    }

    public string[] Components
    {
        get
        {
            return components;
        }
    }

    public int[] ComponentHashs
    {
        get
        {
            return componentHashs;
        }
    }

    private string[] components;
    private int[] componentHashs;

    public ComponentGroup(int key, string[] components,WorldBase world)
    {
        this.key = key;
        this.components = components;
        componentHashs = new int[components.Length];
        for (int i = 0; i < componentHashs.Length; i++)
        {
            componentHashs[i] = world.componentType.GetComponentIndex(components[i]);
        }
    }

}

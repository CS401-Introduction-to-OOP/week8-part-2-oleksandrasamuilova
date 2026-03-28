using System;
using System.Collections.Generic;

namespace Variant1;

public class ResourceManager<T> where T : Resource
{
    private readonly List<T> _resources = new();

    public void Add(T resource)
    {
        _resources.Add(resource);
    }

    public void OpenAll()
    {
        foreach (var res in _resources)
        {
            res.Open();
        }
    }

    public void CloseAll()
    {
        foreach (var res in _resources)
        {
            res.Close();
        }
    }
}
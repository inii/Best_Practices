using Fantasy;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class SingletonDemoTest : Singleton<SingletonDemoTest>, IUpdateSingleton
{
    public int Age;
    public List<Type> Types = new List<Type>();

    public override Task Initialize()
    {
        Age = 1;
        Debug.Log($"SingletonDemoTest Initialize");
        return base.Initialize();
    }


    public void Show()
    {
        Debug.Log($"SingletonDemoTest Show  Age:{Age}");
    }


    protected override void OnLoad(int assemblyName)
    {
        foreach (var type in AssemblyManager.ForEach(assemblyName, typeof(IAssemblyDemo)))
        {
            Types.Add(type);
        }
        Debug.Log($"SingletonDemoTest �����˳���assemblyName:{assemblyName}");
        base.OnLoad(assemblyName);
    }

    protected override void OnUnLoad(int assemblyName)
    {
        Types.Clear();
        Debug.Log($"SingletonDemoTest ж���˳���assemblyName:{assemblyName}");
        base.OnUnLoad(assemblyName);
    }

    public void Update()
    {
        Debug.Log("SingletonDemoTest Update");
    }

  
}

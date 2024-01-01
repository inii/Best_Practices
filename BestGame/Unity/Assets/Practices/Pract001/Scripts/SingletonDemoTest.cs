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
        Debug.Log($"SingletonDemoTest 加载了程序集assemblyName:{assemblyName}");
        base.OnLoad(assemblyName);
    }

    protected override void OnUnLoad(int assemblyName)
    {
        Types.Clear();
        Debug.Log($"SingletonDemoTest 卸载了程序集assemblyName:{assemblyName}");
        base.OnUnLoad(assemblyName);
    }

    public void Update()
    {
        Debug.Log("SingletonDemoTest Update");
    }

  
}

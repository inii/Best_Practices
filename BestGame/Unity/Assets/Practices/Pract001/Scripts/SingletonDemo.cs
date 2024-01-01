using Fantasy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonDemo : MonoBehaviour
{
    #region SingletonSystem介绍
    // SingletonSystem是一个单例管理系统 
    // 只要实现了SingletonSystem接口的类、会注册到SingletonSystem中并管理
    // 直接程序集的加载和卸载
    // 提供一个IUpdateSingleton接口、按帧执行的方法
    #endregion
    void Start()
    {
        Fantasy.Entry.Initialize();
        //SingletonSystem.Initialize();
        AssemblyManager.Load(1, GetType().Assembly);
        SingletonDemoTest.Instance.Show();
    }

 
}

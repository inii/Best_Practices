using Fantasy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IAssemblyDemo
{
    //void Start();
}

public class AssemblyDemoTest : IAssemblyDemo
{

}

#region AssemblyManager介绍

// 网络消息协议、事件等，都使用了反射来实现
// 框架启动的时候会把不同的程序集通过反射拿到继承接口或特性的类、放入缓存中
// 在调用的时候，在缓存中获取、从而提高性能、而不是每次都调用反射执行
// 可以同时加载多个程序集、这个是框架的核心工具
#endregion

public class AssemblyDemo : MonoBehaviour, IAssemblyDemo
{
    // Start is called before the first frame update
    void Start()
    {
        // 雪花算法 时间戳 进程id  世界名

        //foreach (var item in AssemblyManager.ForEachAssemblyName())
        //{
        //    Debug.Log($"assemblyName:{item}");
        //}

        //ForEach: 根据类型或指定的assemblyName返回类型列表
        // 三个重载方法：
        //1.返回某个assemblyName下的所有类型
        //foreach (var type in AssemblyManager.ForEach(1))
        //{
        //    Debug.Log($"type:{type.FullName}");
        //}

        //// 2.在所有程序集中查找实现某一个接口的所有类型
        //foreach (var type in AssemblyManager.ForEach(1, typeof(IAssemblyDemo))){
        //    Debug.Log($"{type.FullName}");
        //}

        // 3.返回assemblyName下的某一个接口的所有类型
        //foreach (var type in AssemblyManager.ForEach(typeof(IAssemblyDemo)))
        //{
        //    Debug.Log($"type.FullName: {type.FullName}");
        //}

        #region AssemblyManager的两个事件
        // OnLoadAssemblyEvent:加载一个程序集的时候调用
        // OnUnLoadAssemblyEvent：卸载一个程序集的时候调用
        #endregion

        AssemblyManager.OnLoadAssemblyEvent += assemblyName =>
        {
            Debug.Log($"加载了一个程序集 assemblyName:{assemblyName}");
        };

        AssemblyManager.OnUnLoadAssemblyEvent += unloadAssembly =>
        {
            Debug.Log($"卸载一个程序集：unloadAssembly：{unloadAssembly}");
        };

        AssemblyManager.Load(1, typeof(AssemblyDemo).Assembly);
        AssemblyManager.Load(1, typeof(AssemblyDemo).Assembly);

    }

 
    void TestSingletonSystem()
    {

    }



}

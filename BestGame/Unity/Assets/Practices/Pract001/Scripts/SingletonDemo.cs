using Fantasy;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonDemo : MonoBehaviour
{
    #region SingletonSystem����
    // SingletonSystem��һ����������ϵͳ 
    // ֻҪʵ����SingletonSystem�ӿڵ��ࡢ��ע�ᵽSingletonSystem�в�����
    // ֱ�ӳ��򼯵ļ��غ�ж��
    // �ṩһ��IUpdateSingleton�ӿڡ���ִ֡�еķ���
    #endregion
    void Start()
    {
        Fantasy.Entry.Initialize();
        //SingletonSystem.Initialize();
        AssemblyManager.Load(1, GetType().Assembly);
        SingletonDemoTest.Instance.Show();
    }

 
}

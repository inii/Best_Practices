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

#region AssemblyManager����

// ������ϢЭ�顢�¼��ȣ���ʹ���˷�����ʵ��
// ���������ʱ���Ѳ�ͬ�ĳ���ͨ�������õ��̳нӿڻ����Ե��ࡢ���뻺����
// �ڵ��õ�ʱ���ڻ����л�ȡ���Ӷ�������ܡ�������ÿ�ζ����÷���ִ��
// ����ͬʱ���ض�����򼯡�����ǿ�ܵĺ��Ĺ���
#endregion

public class AssemblyDemo : MonoBehaviour, IAssemblyDemo
{
    // Start is called before the first frame update
    void Start()
    {
        // ѩ���㷨 ʱ��� ����id  ������

        //foreach (var item in AssemblyManager.ForEachAssemblyName())
        //{
        //    Debug.Log($"assemblyName:{item}");
        //}

        //ForEach: �������ͻ�ָ����assemblyName���������б�
        // �������ط�����
        //1.����ĳ��assemblyName�µ���������
        //foreach (var type in AssemblyManager.ForEach(1))
        //{
        //    Debug.Log($"type:{type.FullName}");
        //}

        //// 2.�����г����в���ʵ��ĳһ���ӿڵ���������
        //foreach (var type in AssemblyManager.ForEach(1, typeof(IAssemblyDemo))){
        //    Debug.Log($"{type.FullName}");
        //}

        // 3.����assemblyName�µ�ĳһ���ӿڵ���������
        //foreach (var type in AssemblyManager.ForEach(typeof(IAssemblyDemo)))
        //{
        //    Debug.Log($"type.FullName: {type.FullName}");
        //}

        #region AssemblyManager�������¼�
        // OnLoadAssemblyEvent:����һ�����򼯵�ʱ�����
        // OnUnLoadAssemblyEvent��ж��һ�����򼯵�ʱ�����
        #endregion

        AssemblyManager.OnLoadAssemblyEvent += assemblyName =>
        {
            Debug.Log($"������һ������ assemblyName:{assemblyName}");
        };

        AssemblyManager.OnUnLoadAssemblyEvent += unloadAssembly =>
        {
            Debug.Log($"ж��һ�����򼯣�unloadAssembly��{unloadAssembly}");
        };

        AssemblyManager.Load(1, typeof(AssemblyDemo).Assembly);
        AssemblyManager.Load(1, typeof(AssemblyDemo).Assembly);

    }

 
    void TestSingletonSystem()
    {

    }



}

using System;
using System.Collections.Generic;
using Fantasy;
using Fantasy.Helper;
using UnityEngine;

namespace BestGame;

public class StartMoveEventHanlder : EventSystem<EventSystemStruct.StartMove>
{
    public override void Handler(EventSystemStruct.StartMove self)
    {
        var unit = self.Unit;
        MoveSyncComponent moveSyncComponent = unit.GetComponent<MoveSyncComponent>();

        // 可以加BroadcastWithAoi，略过...

        moveSyncComponent.AddMessage(unit.Id, self.MoveInfo);
    }
}

public class MoveComponent : Entity 
{
    /// 测试练习，这里不在服务器上做位置的计算与寻路验证
    public async FTask MoveToAsync(MoveInfo moveInfo)
    {
        // 是否禁止移动
        // 获取数值组件，移动速度
        // 寻路，目标点是否有效，是否查找附近有效点

        // 添加广播消息
        MoveToAndSendAsync(moveInfo).Coroutine();
        await FTask.CompletedTask;
    }

    public async FTask MoveToAndSendAsync(MoveInfo moveInfo)
    {
        var unit = (Unit)Parent;
        // 计算移动距离与时间,略角度计算
        float dis = 0;
        float speed = 3;
        Vector3 p0 = MessageInfoHelper.Vector3(unit.moveInfo);
        Vector3 p1 = MessageInfoHelper.Vector3(moveInfo);
        dis = Vector3.Distance(p0, p1);

        moveInfo.MoveEndTime = TimeHelper.Now + (long) (dis / speed * 1000);

        // 添加到广播消息队列
        EventSystem.Instance.Publish(new EventSystemStruct.StartMove{
            Unit = unit, MoveInfo = moveInfo
        });

        // 服务器上的位置移动
        InnerMoveToAsync(unit,moveInfo,speed).Coroutine();
        await FTask.CompletedTask;
    }

    public async FTask InnerMoveToAsync(Unit unit, MoveInfo moveInfo, float speed)
    {
        // 测试练习，略插值计算过程...
        unit.moveInfo = moveInfo;

        await FTask.CompletedTask;
    }
}
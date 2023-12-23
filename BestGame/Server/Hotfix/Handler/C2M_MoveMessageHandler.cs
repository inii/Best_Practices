using Fantasy.Core.Network;
using Fantasy.Helper;
using Fantasy;

namespace BestGame;

public class C2M_MoveMessageHandler : Addressable<Unit,C2M_MoveMessage>
{
    protected override async FTask Run(Unit unit, C2M_MoveMessage message)
    {
        // 路径点非法判断
        // 移动buff组件
        // 停止检测
  
        // 调用MoveComponent
        unit.GetComponent<MoveComponent>().MoveToAsync(message.MoveInfo).Coroutine();

        await FTask.CompletedTask;
    }
}
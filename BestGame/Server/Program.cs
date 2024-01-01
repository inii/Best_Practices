// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

#region Mode参数
// Mode参数是执行框架的启动模式
// Develop：开发模式  所有在配置表中定义的Server都在启动并且都在同一进程下（方便编辑器打断点调试）
// Release 发布模式  启动参数传递的server 就是只会启动一个Server 一个Server是一个进程
#endregion

#region AppType参数
// 框架以什么类型启动 
// Game  游戏服务器  正常的服务器逻辑
// Export 导出配置工具   导出协议、配置表等操作
#endregion

#region AppId参数
    // 告诉框架执行哪个Server、 这个AppId对应的是Server配置表的Id
    // 注意：如果Mode参数执行的是Develop  这参数是不生效的、 因为Develop是启动全部的Server
#endregion

// --Mode Develop --AppType Game
// --AppType Export
Fantasy.Application.Initialize();
// See https://aka.ms/new-console-template for more information
using _14职责链模式ChainofResponsibility;

Flow flow=new Flow("1","测试流程",1);
Approver zs=new TeamLeader("张三");
Approver ls = new Manager("李四");
Approver ww = new Boss("王五");
zs.SetNext(ls);
ls.SetNext(ww);
zs.ApproverFlow(flow);

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14职责链模式ChainofResponsibility {
    //请求类
    public class Flow {
        public string FlowId { get; set; }
        public string FlowName { get; set; }
        public DateTime CreateTime { get; set; }
        public int FlowGrade { get; set; }

        public Flow(string flowId, string flowName, int flowGrade) {
            FlowId = flowId;
            FlowName = flowName;
            CreateTime = DateTime.Now;
            FlowGrade = flowGrade;
        }
    }
    //抽象处理类
    public abstract class Approver {
        protected Approver NextApprover;
        protected string Name;
        public Approver(string name) {
            this.Name = name;
        }
        public void SetNext(Approver nextApprover) {
            this.NextApprover = nextApprover;
        }
        public abstract void ApproverFlow(Flow flow);
    }

    public class TeamLeader : Approver {
        public TeamLeader(string name) : base(name) {
        }

        public override void ApproverFlow(Flow flow) {
            if (flow.FlowGrade < 1) {
                Console.WriteLine($"项目经理{this.Name}通过");
            }
            else
                this.NextApprover.ApproverFlow(flow);
        }
    }

    public class Manager : Approver {
        public Manager(string name) : base(name) {
        }

        public override void ApproverFlow(Flow flow) {
            if (flow.FlowGrade < 2) {
                Console.WriteLine($"部门经理{this.Name}通过");
            }
            else
                this.NextApprover.ApproverFlow(flow);
        }
    }

    public class Boss : Approver {
        public Boss(string name) : base(name) {
        }

        public override void ApproverFlow(Flow flow) {
                Console.WriteLine($"部门经理{this.Name}通过");
        }
    }



}

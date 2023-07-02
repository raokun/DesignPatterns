using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15观察者模式Observer {
    //抽象观察者
    public interface IObserver {
        string Name { get; set; }
        void ObserverUserChange(Company company);
        void SayHello(IObserver observer);
    }
    //观察者
    public class User : IObserver {
        public string Name { get; set; }
        public User(string name) {
            Name = name;
        }
        public void ObserverUserChange(Company company) {
            company.NotifyChanged();
        }

        public void SayHello(IObserver observer) {
            Console.WriteLine($"{Name}欢迎{observer.Name}的加入。");
        }
    }

    //抽象目标
    public abstract class Company {
        public string Name { get; set; }
        public IObserver NewUser { get; set; }
        protected List<IObserver> Users=new List<IObserver>();
        public void Join(IObserver observer) {
            Console.WriteLine($"欢迎{observer.Name}加入{Name}公司");
            NewUser = observer;
            observer.ObserverUserChange(this);
            Users.Add(observer);
        }
        public void leave(IObserver observer) {
            Console.WriteLine($"员工{observer.Name}已从{Name}公司离职");
            Users.Remove(observer);
        }

        public abstract void NotifyChanged();
    }
    //具体目标
    public class BuildCompany : Company {
        public override void NotifyChanged() {
            Console.WriteLine("公司人员变通通知");
            foreach(var user in Users) {
                user.SayHello(NewUser);
            }
        }
    }

}

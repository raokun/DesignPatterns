using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例 {
    public class SingletonExt {
        public static SingletonExt GetSingletonExt() {
            return Locked.singletonExt;
        }
        //延迟初始化(内部类+静态构造函数)
        class Locked {
            static Locked() { }
            internal static readonly SingletonExt singletonExt=new SingletonExt();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例 {

    public class LockSingleton {
        private static LockSingleton instance =null;
        private static Object instanceLock =new Object();
        //双检锁
        public static LockSingleton GetLockSingleton() {
            //一重判断
            if (instance == null) {
                //加锁
                lock (instanceLock) {
                    //二重判断
                    if(instance == null) {
                        instance = new LockSingleton();
                    }
                }
            }
            return instance;

        }
    }
}

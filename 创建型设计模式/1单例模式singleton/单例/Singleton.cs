using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 单例 {
    public class Singleton {
        private static Singleton Instance;
        
        public Singleton() { }
       public static Singleton singleton { 
            get {
                if(Instance == null) {
                    Instance = new Singleton();
                }
                return Instance; 
            } 
        }
    }
}

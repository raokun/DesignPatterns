using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单工厂.model {
    public class CurrentProduceA : Produce {
        public override void Opration() {
            Console.WriteLine("CurrentProduceA制造");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 简单工厂.model;

namespace 简单工厂 {
    public class ProduceFactory {
        public static Produce CreateProduce(int type) {
            switch (type) {
                case 0:
                    return new CurrentProduceA();
                    case 1:
                    return new CurrentProduceB();
                default:
                    throw new ArgumentNullException(nameof(type));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory {
    public interface IColor { public void Display(); }
    public interface IType { public void Display(); }

    public interface IFactory { 
        IColor color();
        IType type();

    }

    public class Green : IColor {
        public Green() { }
        public void Display() { Console.WriteLine("绿色"); }
    }
    public class Red : IColor {
        public Red() { }
        public void Display() { Console.WriteLine("红色"); }
    }
    public class Point:IType {
        public Point() { }

        public void Display() {
            Console.WriteLine("点");
        }
    }
    public class Polygon : IType {
        public Polygon() {
        }

        public void Display() {
            throw new NotImplementedException();
        }
    }
    public class FactoryA:IFactory {
        public FactoryA() { }

        public IColor color() {
            return new Green();
        }

        public IType type() {
            return new Point();
        }
    }

    public class FactoryB : IFactory {
        public FactoryB() { }

        public IColor color() {
            return new Red();
        }

        public IType type() {
            return new Polygon();
        }
    }

}

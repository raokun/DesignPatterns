// See https://aka.ms/new-console-template for more information

using AbstractFactory;

IFactory factory = new FactoryA();
IColor color = factory.color();
IType type = factory.type();
color.Display();
type.Display();

// See https://aka.ms/new-console-template for more information
using _15观察者模式Observer;

BuildCompany build=new BuildCompany();
build.Name = "**建筑公司";
build.Join(new User("张三"));
build.Join(new User("李四"));
build.Join(new User("王五"));

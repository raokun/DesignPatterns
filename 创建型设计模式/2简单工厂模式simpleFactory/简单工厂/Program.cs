// See https://aka.ms/new-console-template for more information
using 简单工厂;
using 简单工厂.model;

int[] ints = new int[] { 0,1,2};
for (var i = 0; i < ints.Length; i++) {
    Produce produce = ProduceFactory.CreateProduce(i);
    produce.Opration();
}


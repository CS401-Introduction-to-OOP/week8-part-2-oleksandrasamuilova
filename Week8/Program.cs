using System;
using Variant1;

var file = new FileResource("dfjndk.txt");
var network = new NetworkResource("kmvlsadld");

var manager = new ResourceManager<Resource>();

manager.Add(file);
manager.Add(network);

manager.OpenAll();
using (var tempFile = new FileResource("tempFile.csv"))
{
    tempFile.Open();
}    

manager.CloseAll();
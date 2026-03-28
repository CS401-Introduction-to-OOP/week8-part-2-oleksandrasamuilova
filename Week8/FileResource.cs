
namespace Variant1;
public class FileResource : Resource, IDisposable
{
public FileResource(string name) : base(name)
{
}
public override void Open()
{
IsOpen = true;
throw new NotImplementedException();
}
public override void Close()
{
IsOpen = false;
throw new NotImplementedException();
}
public void Dispose()
{
Close();
Console.WriteLine($"FileResource {Name} Disposed");
throw new NotImplementedException();
}
}
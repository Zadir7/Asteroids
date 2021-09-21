namespace Utilities.Visitor
{
    public interface ISpawnable
    {
        public void Accept(ISpawnableVisitor visitor);
    }
}
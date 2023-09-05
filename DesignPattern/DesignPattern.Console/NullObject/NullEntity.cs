namespace DesignPattern.Console.NullObject
{
    public sealed class NullEntity : IEntity
    {
       private static Lazy<NullEntity> _entity => new(() => new NullEntity());

        private NullEntity() { }

        public static IEntity Entity => _entity.Value;

        public int Id { get => 0; }
    }
}

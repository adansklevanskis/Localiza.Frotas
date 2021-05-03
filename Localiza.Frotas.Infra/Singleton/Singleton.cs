using System;

namespace Localiza.Frotas.Infra.Singleton
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        public Guid Id { get; } = Guid.NewGuid();

        private Singleton()
        {
        }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }
    }
}

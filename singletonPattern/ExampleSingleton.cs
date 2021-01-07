namespace singletonPattern
{
    public class ExampleSingleton
    {
        private static ExampleSingleton _uniqueInstance = null;

        public int count { get; set; }

        public static ExampleSingleton uniqueInstance()
        {
            if (_uniqueInstance == null)
            {
                _uniqueInstance = new ExampleSingleton();
            }

            return _uniqueInstance;
        }

    }
}
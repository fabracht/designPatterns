namespace SingletonWithLock
{
    /* This singleton implementation makes it multithread safe 
    by the use of a lock.
    The sealed modifier prevents inheritance, since we have a 
    private, we don't actually need to worry about this, but 
    it's (from what I read) considered good practice.
    We don't won't people inheriting and overriding stuff */
    public sealed class SingletonWithLocks
    {
        /* We start by declaring our private instance. The volatile keyword 
        is used to assign a field that might be modified by multiple threads.
        Adding the volatile modifier ensures that all threads will observe 
        volatile writes performed by any other thread in the order in which 
        they were performed. It ensures that the most current value is always 
        present in the field  */
        private static volatile SingletonWithLocks _instance;
        /* We create our lockObject */
        private static object lockObject = new();
        /* Our private constructor prevents the creation of new Instances
        by the use of the "new" command */
        private SingletonWithLocks() { }
        /* Here is our handle to the outside world. The Instance getter
        prevents access to the _instance before it is assigned to something */
        public static SingletonWithLocks Instance
        {
            get
            {
                // Check first
                if (_instance == null)
                {
                    lock (lockObject)
                    {
                        // After locking we need to check again
                        if (_instance == null)
                            _instance = new SingletonWithLocks();
                    }
                }
                // Returning the _instance;
                return _instance;
            }
        }
    }
}
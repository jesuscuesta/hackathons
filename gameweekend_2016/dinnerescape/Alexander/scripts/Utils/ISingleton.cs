using UnityEngine;

public abstract class ISingleton<T> : ExMono where T : ExMono {
    private static T pInstance;
    private static object _lock = new object();
    
    public static T Instance
    {
        get
        {
            lock (_lock)
            {
                if (pInstance == null)
                {
                    GameObject singleton = new GameObject();
                    pInstance = singleton.AddComponent<T>();
                    singleton.name = typeof(T).ToString();
                    DontDestroyOnLoad(singleton);
                }
                return pInstance;
            }
        }
    }
}

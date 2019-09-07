using UnityEngine;

public class Application : MonoBehaviour
{

    //----singleton----
    #region singleton
    private static GameObject _singletonObject;
    public static Application _singleton;
    public static Application Instance
    {
        get
        {
            if (_singleton == null)
            {
                _singletonObject = new GameObject("ApplicationManager");
                DontDestroyOnLoad(_singletonObject);
                _singleton = _singletonObject.AddComponent<Application>();
                _singleton.Initialize();
            }
            return _singleton;
        }
    }
    #endregion
    //-----------------

    //----fields----

    //----propaties----
    public GameMain GameMain
    {
        get;
        private set;
    }

    public SoundPlayer SoundPlayer
    {
        get;
        private set;
    }

    //----methods----
    public void Initialize()
    {
        GameMain = gameObject.AddComponent<GameMain>();
        SoundPlayer = gameObject.AddComponent<SoundPlayer>();
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

public class GameManager : Singleton<GameManager>
{
    private bool m_isGamePaused;

    protected override void Awake()
    {
        Initialize();
    }

    private void OnEnable()
    {
        SubscribeEvents();
    }

    private void OnDisable()
    {
        UnSubscribeEvents();
    }

    private void SubscribeEvents()
    {
        EventManager.I.OnGamePaused += PauseGame;
        EventManager.I.OnGameUnPaused += UnPauseGame;
    }

    private void UnSubscribeEvents()
    {
        EventManager.I.OnGamePaused -= PauseGame;
        EventManager.I.OnGameUnPaused -= UnPauseGame;
    }

    private void Initialize()
    {
    }

    public bool IsGamePaused()
    {
        return m_isGamePaused;
    }

    private void PauseGame()
    {
        m_isGamePaused = true;
    }

    private void UnPauseGame()
    {
        m_isGamePaused = false;
    }
}

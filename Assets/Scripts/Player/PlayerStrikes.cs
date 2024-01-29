using UnityEngine;

public class PlayerStrikes : MonoBehaviour
{
    [SerializeField] private int m_maxPlayerStrikesInclusive;
    private int m_playerStrikes;

    public void StrikePlayer(int _strikeDamageAmount)
    {
        m_playerStrikes -= _strikeDamageAmount;
        if(m_playerStrikes >= m_maxPlayerStrikesInclusive)
        {
            KillPlayer();
        }

        EventManager.I.OnPlayerStrike_Invoke(m_playerStrikes);
    }

    public int GetPlayerStrikes()
    {
        return m_playerStrikes;
    }

    private void KillPlayer()
    {
        GameManager.I.LoseGame();
    }
}

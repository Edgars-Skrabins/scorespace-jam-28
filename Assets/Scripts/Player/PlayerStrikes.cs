using UnityEngine;

public class PlayerStrikes : MonoBehaviour
{
    [SerializeField] private int m_maxPlayerStrikesInclusive;
    private int m_playerStrikes;

    public void StrikePlayer(int _strikeDamageAmount)
    {
        m_playerStrikes -= _strikeDamageAmount;
        if(m_playerStrikes <= 0)
        {
            //KillPlayer();
        }
        AudioManager.I.PlaySound("GettingHit");
        EventManager.I.OnPlayerStrike_Invoke(m_playerStrikes);
    }

    public int GetPlayerStrikes()
    {
        return m_playerStrikes;
    }

    private void KillPlayer()
    {
        AudioManager.I.PlaySound("PlayerDead");
        GameManager.I.LoseGame();
    }
}

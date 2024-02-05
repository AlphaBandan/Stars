using UnityEngine;
using System.Collections;

public class Sensor_Bandit : MonoBehaviour {

    [SerializeField]
    private int m_ColCount = 0;
    [SerializeField]
    private float m_DisableTimer;

    private void OnEnable()
    {
        m_ColCount = 0;
    }

    public bool State()
    {
        if (m_DisableTimer > 0)
            return false;
        return m_ColCount > 0;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Checks if Object it is colliding with is the ground (stops being able to jump if next to cat)
        if (other.tag == "Ground")
        {
            m_ColCount++;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            m_ColCount--;
        }
    }

    void Update()
    {
        m_DisableTimer -= Time.deltaTime;
    }

    public void Disable(float duration)
    {
        m_DisableTimer = duration;
    }
}

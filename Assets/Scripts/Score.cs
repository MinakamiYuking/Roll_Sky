using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text score_text;

    void FixedUpdate()
    {
        score_text.text = player.position.z.ToString("0") ;
    }
}

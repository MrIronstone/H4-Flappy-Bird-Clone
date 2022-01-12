using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameManager.instance.IncreaseScore(1);
        SoundManager.instance.PlaySound(GameManager.instance.pointEffect);
    }
}

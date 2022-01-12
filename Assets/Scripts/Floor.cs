using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    [SerializeField] private Animator animator;

    private void FixedUpdate()
    {
        animator.speed = GameManager.instance.gameSpeed;
    }

}

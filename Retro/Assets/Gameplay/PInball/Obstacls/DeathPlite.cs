using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlite : MonoBehaviour
{
    [SerializeField] private BallManager _ballManager;
    private void OnCollisionEnter(Collision collision)
    {
        _ballManager.BallKill();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlite : MonoBehaviour
{
    [SerializeField] private BallManager _ballManager;
    [SerializeField] private GameObject _hatch;
    private void OnCollisionEnter(Collision collision)
    {
        _ballManager.BallKill();
        _hatch.SetActive(false);
    }
}

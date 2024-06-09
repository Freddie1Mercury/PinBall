using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ObstaclForce : MonoBehaviour
{
    [SerializeField] private int _force = 30;
    [SerializeField] private PinBallUiManager _pinBallUiManager;
    private const int _point = 100;
    private Vector2 _direction;


    private void OnCollisionEnter(Collision collision)
    {
        _direction = collision.gameObject.transform.position.normalized;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(-_direction * _force, ForceMode.Impulse);
        _pinBallUiManager.AddPoint();
    }

   
    
}

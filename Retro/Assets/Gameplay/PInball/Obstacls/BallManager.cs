using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallManager : MonoBehaviour
{
    [SerializeField] private Transform _startPosition;
    [SerializeField] private GameObject _hatch;
    [SerializeField] private TextMeshProUGUI _lifeCounterAmountText;
    [SerializeField] private PinBallUiManager _pinBallUiManager;
    [SerializeField] private PinballManager _pinballManager;
    public bool _ballDeath = true;
    private int _ballLife = 3;
    public int BallLife
    {
        get { return _ballLife; }
        set { _ballLife = value; }

    }
    public void BallKill()
    {
        if (_ballLife > 0)
        {
            _ballLife--;
        }
        else if (_ballLife == 0)
        {
            _pinballManager.PinballRestart();
        }
        transform.position = _startPosition.position;
        transform.rotation = _startPosition.rotation;
        transform.GetComponent<Rigidbody>().velocity = Vector3.zero;
        _ballDeath = true;
        _pinBallUiManager.TextUpdate();

    }

    public void BallStartForce(InputAction.CallbackContext context)
    {
        StartCoroutine(HatchWait());
        transform.position = _startPosition.position;
        transform.rotation = _startPosition.rotation;
        transform.GetComponent<Rigidbody>().velocity = Vector3.zero;
        int force = 4000;
        transform.GetComponent<Rigidbody>().AddForce(transform.up * force, ForceMode.Force);
    }

    private IEnumerator HatchWait()
    {
        if (_ballDeath = true)
        {
            yield return new WaitForSeconds(2);
            _hatch.SetActive(true);
        }
 
    }
}

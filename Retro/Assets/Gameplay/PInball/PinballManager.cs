using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinballManager : MonoBehaviour
{
    [SerializeField] private PinBallUiManager _pinBallUiManager;
    [SerializeField] private BallManager _ballManager;
    [SerializeField] private GameObject _pinBall;
    [SerializeField] private GameObject _ball;
    [SerializeField] private GameObject _EndGamePanel;
    public void PinballRestart()
    {
        _pinBallUiManager.UpdateRecordTable();
        _pinBallUiManager.PointAmount = 0;
        _ballManager.BallLife = 3;
        _pinBallUiManager.TextUpdate();
        _pinBall.SetActive(false);
        _ball.SetActive(false);
        _EndGamePanel.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PinBallUiManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _pointAmountText;
    [SerializeField] private TextMeshProUGUI _lifeCounterAmountText;
    [SerializeField] private TextMeshProUGUI _recordTableAmountText;
    [SerializeField] private BallManager _ballManager;
    public int PointAmount;
    private const int _point = 100;


    public void AddPoint()
    {
        PointAmount += _point;
        TextUpdate();

    }
    public void TextUpdate()
    {
        _pointAmountText.text = PointAmount.ToString();
        _lifeCounterAmountText.text = _ballManager.BallLife.ToString();
    }
    
    public void UpdateRecordTable()
    {
        if (int.Parse( _recordTableAmountText.text) >= PointAmount)
        {
            return;
        }
        else
        {
            _recordTableAmountText.text = PointAmount.ToString();
        }
    }
}

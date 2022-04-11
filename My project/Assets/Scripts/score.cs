using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class score : MonoBehaviour
{
    // Assign the TextMeshPro component here in the inspector
    [SerializeField] private TextMeshPro textField;
    private float textValue;

    private void Start()
    {
        textValue = float.Parse(textField.text);
    }

    public void AddScore(float increase)
    {
        textValue += increase;
        textField.text = textValue.ToString();
    }

}
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TextReader : MonoBehaviour
{
    [Header("Dependencies")]
    [SerializeField]
    private TextAsset _file;

    [SerializeField] private string[] _names;

    void OnValidate() =>
        _names = _file ? _file.text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries) : null;
    
}

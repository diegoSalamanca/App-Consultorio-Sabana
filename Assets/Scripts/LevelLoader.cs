using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelLoader : MonoBehaviour
{
    Button button;

    public string level;

    private void Start()
    {
        button = GetComponent<Button>();

        button.onClick.AddListener(LoadLevel);
    }

    public void LoadLevel()
    {
        FindObjectOfType<LoaderManager>().StartLoadLevel(level);
    }
}

    

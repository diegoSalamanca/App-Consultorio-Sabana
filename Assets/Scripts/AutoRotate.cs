using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var hash = iTween.Hash("y", 180f, "time", 3f, "looptype", "loop", "easetype", iTween.EaseType.linear);
        iTween.RotateTo(gameObject, hash);
    }

   
}

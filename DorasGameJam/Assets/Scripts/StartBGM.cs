using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartBGM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SoundPlayer.Instance.PlayBGM("Game");
    }
}

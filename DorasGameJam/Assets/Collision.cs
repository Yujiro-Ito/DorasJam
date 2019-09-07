using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    Coroutine _switchScene;
    [SerializeField] ParticleSystem _goalEffect;

    // Start is called before the first frame update
    void Start()
    {
        _switchScene = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (_switchScene != null) return;
        _switchScene = StartCoroutine(Goal());
    }

    private IEnumerator Goal()
    {
        _goalEffect.Play();
        SoundPlayer.Instance.PlaySE("Clear");
        yield return new WaitForSeconds(2);
        GameObject.FindObjectOfType<SwitchScene>().OnResult();
    }
}

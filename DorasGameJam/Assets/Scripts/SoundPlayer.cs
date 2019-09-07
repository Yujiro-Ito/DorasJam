using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    //----singleton----
    private static SoundPlayer _singleton;
    public static SoundPlayer Instance
    {
        get
        {
            if (_singleton == null)
            {
                GameObject tmp = new GameObject("SoundPlayer");
                _singleton = tmp.AddComponent<SoundPlayer>();
                _singleton.InitializeAudioSources();
                SoundLoad.LoadAllSounds(_singleton);
            }

            return _singleton;
        }
    }

    //----static fields----
    public static readonly int BGM_CH = 1;
    public static readonly int SE_CH = 5;

    //----fields----
    AudioSource[] _bgmSources;
    AudioSource[] _seSources;
    int _currentIndexBGM, _currentIndexSE;
    Dictionary<string, AudioClip> _bgmClips = new Dictionary<string, AudioClip>();
    Dictionary<string, AudioClip> _seClips = new Dictionary<string, AudioClip>();


    public void InitializeAudioSources()
    {
        _bgmSources = new AudioSource[BGM_CH];
        _seSources = new AudioSource[SE_CH];
        for (int i = 0; i < _bgmSources.Length; i++)
        {
            _bgmSources[i] = gameObject.AddComponent<AudioSource>();
        }
        for (int i = 0; i < _seSources.Length; i++)
        {
            _seSources[i] = gameObject.AddComponent<AudioSource>();
        }
        _currentIndexBGM = 0;
        _currentIndexSE = 0;

    }

    public void LoadBGM(string key, string srcName)
    {
        AudioClip clip = Resources.Load<AudioClip>("Sounds/BGM/" + srcName);
        if (clip == null)
        {
            Debug.LogError(srcName + "は読み込めませんでした。", this);
            return;
        }
        if (_bgmClips.ContainsKey(key))
        {
            Debug.Log(key + "は既に登録されています。");
            return;
        }
        _bgmClips.Add(key, clip);
    }

    public void LoadSE(string key, string srcName)
    {
        AudioClip clip = Resources.Load<AudioClip>("Sounds/SE/" + srcName);
        if (clip == null)
        {
            Debug.LogError(srcName + "は読み込めませんでした。", this);
            return;
        }
        if (_seClips.ContainsKey(key))
        {
            Debug.Log(key + "は既に登録されています", this);
            return;
        }
        _seClips.Add(key, clip);
    }

    public void LoadVoice(string key, string srcName)
    {
        AudioClip clip = Resources.Load<AudioClip>("Sounds/Voices/" + srcName);
        if (clip == null)
        {
            Debug.LogError(srcName + "は読み込めませんでした。", this);
            return;
        }
        if (_seClips.ContainsKey(key))
        {
            Debug.Log(key + "は既に登録されています", this);
            return;
        }
        _seClips.Add(key, clip);
    }

    public AudioSource PlayBGM(string key, AudioSource source = null)
    {
        if (!_bgmClips.ContainsKey(key))
        {
            Debug.LogError(key + "は登録されていません。");
            return null;
        }

        if (source == null)
        {
            source = _bgmSources[_currentIndexBGM];
            _currentIndexBGM = (++_currentIndexBGM >= _bgmSources.Length) ? 0 : _currentIndexBGM;
        }


        source.clip = _bgmClips[key];
        source.Play();
        source.loop = true;
        return source;
    }

    public void StopAllBGM()
    {
        foreach (AudioSource source in _bgmSources)
        {
            source?.Stop();
        }
    }

    public AudioSource PlaySE(string key, AudioSource source = null)
    {
        if (!_seClips.ContainsKey(key))
        {
            Debug.LogError(key + "は登録されていません。");
            return null;
        }

        if (source == null)
        {
            source = _seSources[_currentIndexSE];
            _currentIndexSE = (++_currentIndexSE >= _seSources.Length) ? 0 : _currentIndexSE;
        }

        source.clip = _seClips[key];
        source.Play();
        source.loop = false;
        return source;
    }

    public AudioSource PlayVoice(string key, AudioSource source = null)
    {
        return PlaySE(key, source);
    }


}

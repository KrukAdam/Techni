using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance { get; private set; }

    [SerializeField] private bool dontDestroyOnLoad = false;

    protected virtual void Awake()
    {
        if (Instance != null)
        {
            DestroyImmediate(gameObject);
            return;
        }

        Instance = GetComponent<T>();

        if (dontDestroyOnLoad) DontDestroyOnLoad(gameObject);

        SetupOnAwake();
    }

    protected virtual void SetupOnAwake()
    {

    }
}



public class AudioManager : Singleton<AudioManager>
{
    public int X;

    public Dictionary<string, AudioClip> clips;
    public AudioSource audioSource;

    public event Action<int> OnUpdate = delegate { };


    protected override void Awake()
    {
        base.Awake();
        X = 11;
    }

    public void PlayMusic(string id)
    {
        audioSource.clip = clips[id];
        audioSource.Play();
        OnUpdate(X);
    }
}

public class UiView : MonoBehaviour
{
    public Text textTMP;

    private void OnEnable()
    {
        AudioManager.Instance.OnUpdate += UpdateText;
    }

    private void OnDestroy()
    {
        AudioManager.Instance.OnUpdate -= UpdateText;
    }

    public void UpdateText(int X)
    {
        textTMP.text = X.ToString();
    } 
}
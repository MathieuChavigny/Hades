using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{

    [SerializeField] private AudioClip _intro;
    [SerializeField] private AudioClip _explication;
    [SerializeField] private AudioClip _cerbere;
    [SerializeField] private AudioSource _audio;

    public bool _isCerbereDit = false;
    public bool _isExplicationDit = false;


    // Start is called before the first frame update
    void Start()
    {
        // _audio.GetComponent<AudioSource>();
        Intro();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Intro()
    {
        _audio.PlayOneShot(_intro);
        Invoke("explication", _intro.length);
    }

    public void explication()
    {
        if (_isExplicationDit == false)
        {
            _isExplicationDit = true;
            _audio.PlayOneShot(_explication);

        }
    }


    public void Cerbere()
    {
        if (_isCerbereDit == false)
        {
            _isCerbereDit = true;
            _audio.Stop();
            _audio.PlayOneShot(_cerbere);
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Cerbere : MonoBehaviour
{
    [SerializeField] private SOCerbere _soCerbere;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        _soCerbere.nbTete = 0;

    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        // Debug.Log("nbTete : " + _soCerbere.nbTete);
        if (_soCerbere.nbTete == 3)
        {
            SceneManager.LoadScene(3);

        }
    }


    public void plusTete()
    {
        _soCerbere.nbTete++;

    }

    public void MoinsTete()
    {
        _soCerbere.nbTete--;

    }


}

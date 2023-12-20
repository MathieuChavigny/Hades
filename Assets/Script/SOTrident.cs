using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SOTrident", menuName = "ScriptableObjects/SOTrident", order = 1)]
public class SOTrident : ScriptableObject
{

    [SerializeField] private int _nbTrident = 0;
    public int nbTrident { get => _nbTrident; set => _nbTrident = value; } //accesseur pour permettre l'acces par l'exterieur du script
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

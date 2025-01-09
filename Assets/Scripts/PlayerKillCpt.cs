using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKillCpt : MonoBehaviour
{
    public int CptKill;    

    public static PlayerKillCpt Instance;

    void Awake()
    {
        Instance = this;
    }

    public void AddCptKill()
    {
        CptKill += 1;
    }

    public int GetCptKill()
    {
        return CptKill;
    }

}

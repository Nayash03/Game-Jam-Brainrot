using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuiPlayerKillCpt : MonoBehaviour
{
  
    public Text healthText;
    public int cpt;
    

    
    

    void Update ()
    {
        if (PlayerKillCpt.Instance != null)
        {
            cpt = PlayerKillCpt.Instance.GetCptKill();
        }
        healthText.text = cpt.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class PlayerKillCpt : MonoBehaviour
{
    public int CptKill;    

    public VideoPlayer videoPlayer;

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

    void Update()
    {
        if (CptKill >= 10)
        {
            videoPlayer.Play(); 
            StartCoroutine(WaitAfterVideo());
        }
    }

    IEnumerator WaitAfterVideo()
    {
        
        yield return new WaitForSeconds(24f);
    
        SceneManager.LoadScene("Menu"); 
    }
}

using UnityEngine;
using System.Collections;

public class ExMono : MonoBehaviour {

    private static GameCore pCore;

    private void Awake()
    {
        
    }
    public GameCore getGameCore()
    {
        if (ExMono.pCore == null)
            pCore = GameObject.Find("GameCore").GetComponent<GameCore>();
        return pCore;
    }
}
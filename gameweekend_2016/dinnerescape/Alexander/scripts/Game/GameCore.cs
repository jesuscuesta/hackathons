using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameCore : ISingleton<GameCore> {

    protected GameCore() {
        dictionary = new Dictionary<string, string>();
    }

    private Dictionary<string, string> dictionary;

    public void SetValue(string key, string value )
    {
        dictionary.Add(key, value);
    }

    public string GetValue(string key)
    {
        if (dictionary.ContainsKey(key))
            return dictionary["key"];
        else return "";
    }
}

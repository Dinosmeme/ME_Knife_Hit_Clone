﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class BaseController : MonoBehaviour {
    public GameObject gameMaster;
    public string sceneName;

    protected virtual void Awake()
    {
        if (GameMaster.instance == null && gameMaster != null)
            Instantiate(gameMaster);
    }

    protected virtual void Start()
    {

    }

    public virtual void OnApplicationPause(bool pause)
    {
        Debug.Log("On Application Pause");
    }

    private IEnumerator SavePrefs()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            PlayerPrefs.Save();
        }
    }
}

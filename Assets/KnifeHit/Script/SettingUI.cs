using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingUI : MonoBehaviour
{

	[Header("Setting View")]
	public Toggle soundToggle;
	public Toggle vibrationToggle;
	public GameObject UIParent;
	public Text removeAdPriceText;
	public static SettingUI intance;

	void Awake()
	{
		if (intance == null)
		{
			intance = this;
		}
	}

	void Start()
	{

		soundToggle.onValueChanged.RemoveAllListeners();
		vibrationToggle.onValueChanged.RemoveAllListeners();
		updateUI();
		soundToggle.onValueChanged.AddListener((arg0) =>
		{
			GameManager.Sound = arg0;
			if (arg0)
				SoundManager.instance.PlaybtnSfx();
		});
		vibrationToggle.onValueChanged.AddListener((arg0) =>
		{
			GameManager.Vibration = arg0;
			if (arg0)
				SoundManager.instance.playVibrate();
		});

	}

	public void showUI()
	{
		UIParent.SetActive(true);
	}

	public void updateUI()
	{
		soundToggle.isOn = GameManager.Sound;
		vibrationToggle.isOn = GameManager.Vibration;
	}
}

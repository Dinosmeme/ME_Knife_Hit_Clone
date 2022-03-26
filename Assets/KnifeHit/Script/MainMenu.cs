using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class MainMenu : MonoBehaviour 
{
	[Header("Main View")]
	public Button giftButton;
	public Text giftLable;
	public CanvasGroup giftLableCanvasGroup;
	public GameObject giftBlackScreen;
	public GameObject giftParticle;
	public Image selectedKnifeImage;
	public AudioClip giftSfx;

	public static MainMenu intance;

	void Awake()
	{
		intance = this;
	}
	void Start()
	{
		KnifeShop.intance.UpdateUI ();
	}

	public void OnPlayClick()
	{
		Vibration.Init();
		Vibration.VibratePop();
		SoundManager.instance.PlaybtnSfx ();
		GeneralFunction.intance.LoadSceneWithLoadingScreen ("GameScene");
	}


	public void OpenShopUI()
	{
		Vibration.Init();
		Vibration.VibratePop();
		SoundManager.instance.PlaybtnSfx ();
		KnifeShop.intance.showShop ();	
	}
	public void OpenSettingUI()
	{
		Vibration.Init();
		Vibration.VibratePop();
		SoundManager.instance.PlaybtnSfx ();
		SettingUI.intance.showUI();	
	}
}


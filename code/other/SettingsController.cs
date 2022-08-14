using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsController : MonoBehaviour
{
	public AudioMixer audiomixer;
    

    public void SetVolumeSFX(float volume)
	{
		audiomixer.SetFloat("SFX", volume);
	}
    public void SetVolumeMusic(float volume)
    {
        audiomixer.SetFloat("MUSIC", volume);
    }

    public void SetFullScreen(bool IsFullScreen)
	{
		Screen.fullScreen = IsFullScreen;
	}
}

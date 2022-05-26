using UnityEngine.Audio;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public bool audioIsPlaying;
    // Start is called before the first frame update
    void Awake()
    {
        foreach (Sound s in sounds){
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }


    public void PlayMusic(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    public void PlaySound(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayOneShot(s.source.clip);
    }

    public void AudioIsPlayingCheck(string name){
        Sound s = Array.Find(sounds, sound => sound.name == name);

        if (s.source.isPlaying){
            audioIsPlaying = true;
        }
        else{
            audioIsPlaying = false;
        }
        
    }

    private void Start()
    {
        PlayMusic(PlayerPrefs.GetString("song_name"));
        audioIsPlaying = true;
    }

    private void Update() {
        AudioIsPlayingCheck(PlayerPrefs.GetString("song_name"));
    }
}   

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.loop = true;
        source.PlayOneShot(clip);

    }

    public void Update()
    {
        source.pitch += Time.deltaTime * 0.005f;
    }

}

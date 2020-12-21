using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    public string levelName;
    public ParticleSystem particles;
    public GameObject portalSurface;

    private Gemstone[] gemsInScene;

    private bool portalOpen = false;

    private Jukebox jq;

    void Awake()
    {
        gemsInScene = FindObjectsOfType<Gemstone>();
    }

    private void Start()
    {
        jq = FindObjectOfType<Jukebox>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckPortalOpen();
    }

    private void CheckPortalOpen()
    {
        if (gemsInScene.Length == 0)
            portalOpen = true;
        else
            portalOpen = gemsInScene.All(gem => gem.hasBeenClaimed);

        if (portalOpen)
        {
            if(!particles.isPlaying)
                particles.Play();
            portalSurface.SetActive(true);
        }
        else
        {
            particles.Stop();
            portalSurface.SetActive(false);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && portalOpen)
        {
            SceneManager.LoadScene(levelName);
            jq.PlayPortalEnter();
        }
    }
}

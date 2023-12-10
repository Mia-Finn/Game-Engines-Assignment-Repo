using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeSkybox : MonoBehaviour
{
    public Material dayMaterial;
    public Material nightMaterial;
    public GameObject nightAudio, dayAudio;
    // Start is called before the first frame update
    void Start()
    {
      //  dayTime();
        //RenderSettings.skybox = dayMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dayTime()
    {
        RenderSettings.skybox = dayMaterial;
        nightAudio.SetActive(false);
        dayAudio.SetActive(true);
    }

    public void nightTime()
    {
        RenderSettings.skybox = nightMaterial;
        nightAudio.SetActive(true);
        dayAudio.SetActive(false);
    }
}

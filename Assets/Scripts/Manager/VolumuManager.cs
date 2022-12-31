using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumuManager : MonoBehaviour
{
    [SerializeField]
    private AudioMixer audioMixer;
    [SerializeField]
    private Slider master;

    // Start is called before the first frame update
    void Start()
    {
        audioMixer.GetFloat("MasterVolumu", out float masterVolumu);
        master.value = masterVolumu;
    }

    public void SetMaster(float volumu)
    {
        audioMixer.SetFloat("MasterVolumu", volumu);
    }

}

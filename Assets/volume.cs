
using UnityEngine;

public class volume : MonoBehaviour
{
    private AudioSource audioSource;
    private float volumeValue;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        audioSource.volume = volumeValue;
    }
    public void SetValue(float value)
    {
        volumeValue = value;
    }
}

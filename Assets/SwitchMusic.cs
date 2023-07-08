using UnityEngine;

public class SwitchMusic : MonoBehaviour
{
    public AudioSource boomBoxAudioSource;
    public AudioSource headFoneAudioSource;

    private bool isSpriteActive = true;
    private int boomBoxtimer;
    private int headFoneTImer;

    private void Start()
    {
        boomBoxAudioSource.Play();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isSpriteActive)
            {
                boomBoxtimer = boomBoxAudioSource.timeSamples;
                boomBoxAudioSource.Stop();
            }
            else
            {
                headFoneTImer = headFoneAudioSource.timeSamples;
                headFoneAudioSource.Stop();
            }

           isSpriteActive = !isSpriteActive;

            if (isSpriteActive)
            {
                boomBoxAudioSource.timeSamples = headFoneTImer;
                boomBoxAudioSource.Play();
                Debug.Log("Switching to boomBox. Sample position: " + headFoneTImer);
            }
            else
            {
                headFoneAudioSource.timeSamples = boomBoxtimer;
                headFoneAudioSource.Play();
                Debug.Log("Switching to headFone. Sample position: " + boomBoxtimer);
            }
        }
    }
}

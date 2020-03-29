using UnityEngine;

public class ActiveerKnop : MonoBehaviour
{
    public GameObject AllParticles;
    public GameObject Audio;
    public GameObject CutsceneCamera;
    public GameObject PlayerCamera;
    public GameObject Timeline;

    void OnCollisionEnter()
    {
        AllParticles.SetActive(true);
        Audio.SetActive(true);
        CutsceneCamera.SetActive(true);
        Timeline.SetActive(true);
        PlayerCamera.SetActive(false);
    }
}

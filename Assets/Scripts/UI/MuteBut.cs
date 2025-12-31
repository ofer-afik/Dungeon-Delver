using UnityEngine;
using UnityEngine.UI;

public class MuteBut : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Image icon;
    public Sprite mutedIcon;
    public Sprite unmutedIcon;
    public void OnPress()
    {
        if (AudioListener.volume == 1f)
        {
            AudioListener.volume = 0f;
            icon.sprite = mutedIcon;
        }
        else
        {
            AudioListener.volume = 1f;
            icon.sprite = unmutedIcon;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

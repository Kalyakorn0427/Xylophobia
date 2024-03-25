using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetVolumeSlider : MonoBehaviour
{
    [SerializeField] UIMenu UIMenu;
    public Slider volumeSlider;
    private static float volumeVaule;
    // Start is called before the first frame update
    private void Start()
    {
        volumeSlider.value = volumeVaule;
    }

    public void VtoS()
    {
        volumeVaule = volumeSlider.value;
    }
}

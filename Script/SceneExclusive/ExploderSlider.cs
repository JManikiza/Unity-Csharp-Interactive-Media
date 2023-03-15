using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ExploderSlider : MonoBehaviour
{
    // Start is called before the first frame update

    Animator anim;
    public Slider slider;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        anim.Play("Explode", -1, slider.value);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class UiController : MonoBehaviour
{
    [FormerlySerializedAs("killButton")] public Image killImage;

    private CanvasStore cs;

    public Color active, inactive;

    public Image hiddenImage, dashImage;

    private Movement mov;
    
    void Start()
    {
        cs = GameObject.FindGameObjectWithTag("Canvas").GetComponent<CanvasStore>();
        mov = GetComponent<Movement>();
        killImage = cs.killImg;
        dashImage = cs.dashImg;
        hiddenImage = cs.hiddenImage;
        killImage.color = inactive;

    }

    // Update is called once per frame
    void Update()
    {
        dashImage.color = !mov.canDash ? active : inactive;
    }

    public void ShowKillButton()
    {
        killImage.color = active;
    }

    public void HideKillButton()
    {
        killImage.color = inactive;
    }
    
    public void HideDashImg()
    {
        dashImage.color = inactive;
    }
    
    public void ShowDashImg()
    {
        dashImage.color = active;
    }
    
    
    public void ShowHiddenImg()
    {
        hiddenImage.color = active;
    }
    
    public void HideHiddenImg()
    {
        hiddenImage.color = inactive;
    }



}

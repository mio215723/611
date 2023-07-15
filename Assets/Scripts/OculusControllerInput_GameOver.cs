using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;
using UnityEngine.SceneManagement;

public class OculusControllerInput_GameOver : MonoBehaviour
{    
    private void Start()
    {
        Invoke("Delay",10.0f);
    }

    private void Update()
    {
        // X(右はA) Button押下中
        bool x_button = OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.LTouch);
        // Y(右はB) Button押下中
        bool y_buttonL = OVRInput.Get(OVRInput.Button.Two, OVRInput.Controller.LTouch);
        // Menu Button押下中
        bool menu_buttonL = OVRInput.Get(OVRInput.Button.Start, OVRInput.Controller.LTouch);
        // Thumb Stick押下中
        bool stickL = OVRInput.Get(OVRInput.Button.PrimaryThumbstick, OVRInput.Controller.LTouch);
        // Triggerを押下中
        bool triggerL = OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch);
        // Grip Buttonを押下中
        bool gripL = OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.LTouch);

        bool a_button = OVRInput.Get(OVRInput.Button.One, OVRInput.Controller.RTouch);
        // Y(右はB) Button押下中
        bool b_button = OVRInput.Get(OVRInput.Button.Two, OVRInput.Controller.RTouch);
        // Thumb Stick押下中
        bool stickR = OVRInput.Get(OVRInput.Button.PrimaryThumbstick, OVRInput.Controller.RTouch);
        // Triggerを押下中
        bool triggerR = OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch);
        // Grip Buttonを押下中
        bool gripR = OVRInput.Get(OVRInput.Button.PrimaryHandTrigger, OVRInput.Controller.RTouch);

        // トリガーボタンが押されたら何らかのアクションを実行
        if (triggerR || triggerL)
        {
            SceneManager.LoadScene("Title");
        }
    }

    private void Delay()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;
using UnityEngine.SceneManagement;

public class OculusControllerInput : MonoBehaviour
{    
    private void Update()
    {
        // トリガーボタンの入力を検出
        bool LTriggerPressed = OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.LTouch);
        bool RTriggerPressed = OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch);

        // トリガーボタンが押されたら何らかのアクションを実行
        if (LTriggerPressed || RTriggerPressed)
        {
            SceneManager.LoadScene("Title");
        }
    }
}

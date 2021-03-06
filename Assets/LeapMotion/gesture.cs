﻿using System.Collections.Generic;
using UnityEngine;
using Leap;

public class gesture : MonoBehaviour
{

    Controller controller;
    HandModel hand_model;
    public GameObject kekkai;
    public ParticleSystem particle2;


    void Start()
    {
        controller = new Controller();
        // スワイプのジェスチャーを有効にする
        controller.EnableGesture(Gesture.GestureType.TYPESWIPE);
    }

    void Update()
    {

        Frame frame = controller.Frame();
        GestureList leap_gestures = frame.Gestures();

        for (int i = 0; i < leap_gestures.Count; i++)
        {

            Gesture gesture = leap_gestures[i];
            //            if (gesture.Type == Gesture.GestureType.TYPECIRCLE) {
            //                Debug.Log ("maru");
            //            }
            //ジェスチャーがスワイプだった場合
            if (gesture.Type == Gesture.GestureType.TYPESWIPE)
            {

                SwipeGesture Swipe = new SwipeGesture(gesture);
                // スワイプ方向
                Vector SwipeDirection = Swipe.Direction;
                // 0より小さかった場合（下げてる）
                if (SwipeDirection.y < 0)
                {
                    // Downのログを表示
                    Debug.Log("Down");
                    //kekkai.SetActive (false);
                    GameObject kekkaiobj = kekkai.gameObject;
                    kekkaiobj.GetComponent<Renderer>().enabled = false;
                    particle2.Play();

                    // 0より大きかった場合（上にあげてる）
                }
                else if (SwipeDirection.y > 0)
                {
                    // Upのログを表示
                    Debug.Log("Up");
                    GameObject kekkaiobj = kekkai.gameObject;
                    kekkaiobj.GetComponent<Renderer>().enabled = true;
                    particle2.Stop();
                }
            }
        }

    }
}

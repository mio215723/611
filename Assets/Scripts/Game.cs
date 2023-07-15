using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    private int num_of_maked_ramen; //作ったラーメンの数
    private float sec_of_touching_wh; //ラーメンに熱湯をそそいた秒数
    private bool is_having_ramen; //ラーメンを持っているかどうか

    // Start is called before the first frame update
    void Start()
    {
        num_of_maked_ramen = 0;
        sec_of_touching_wh = 0.0f;
        is_having_ramen = false;
    }

    void Update()
    {

    }

    // bool GetHavingRamen()
    // {
    //     return is_having_ramen;
    // }

    // 衝突した時に呼び起こされる関数
    void OnCollisionEnter(Collision collision)
    {
        if((collision.gameObject.name == "ramen0") || (collision.gameObject.name == "ramen1") || (collision.gameObject.name == "ramen2"))
        {   //ラーメンに衝突した場合
            if(is_having_ramen == false)
            {
                is_having_ramen = true;
                Destroy(collision.gameObject); //とったラーメンを消す
            }

        }else if(collision.gameObject.name == "sano")
        {   //佐野さんに衝突した場合
            SceneManager.LoadScene("GameOver");
            // Debug.Log("game over");

        
        }else if(collision.gameObject.name == "kono")
        {
            if(is_having_ramen)
            {   //河野先生に衝突した場合
                if(is_having_ramen == true)
                {
                    is_having_ramen = false;
                    num_of_maked_ramen = num_of_maked_ramen + 1;

                    if(num_of_maked_ramen == 3)
                    {
                        SceneManager.LoadScene("GameClear");
                        // Debug.Log("game clear");
                    }
                }
            }
        }

    }

    void OnCollisionStay(Collision collision)
    {
        sec_of_touching_wh += Time.deltaTime;

    }

}

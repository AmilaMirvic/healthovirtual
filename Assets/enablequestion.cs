using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enablequestion : MonoBehaviour
{ 
    public GameObject TextObj;
    // Start is called before the first frame update
    //void Start()
   //{
   //     UnlockMouse();
   // }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnableText (){
    TextObj.SetActive(true);
    }

    //void UnlockMouse(){
      //  Cursor.lockState = CursorLockMode.None;
       // Cursor.visible = true;
  //  }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class simple_raycasting : MonoBehaviour
{



    public ARRaycastManager raycastmanager;
    public GameObject objectToplacePrefab;
    public Camera raycastCamera;

    private GameObject objectInstance;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>();


    // Update is called once per frame
    void Update()
    {
        if (raycastmanager == null)   //ถ้าไม่เจอก็ให้มันหยุดทำงาน
            return;
        if (raycastCamera == null)   //ถ้าไม่เจอก็ให้มันหยุดทำงาน
            return;
        if (Input.GetMouseButtonDown(0))   //ถ้านิ้ว touch ที่ screen
        {
            Ray ray = raycastCamera.ScreenPointToRay(Input.mousePosition);   //cast ray จากตำแหน่งกล้อง

            if(raycastmanager.Raycast(ray, hits))   //ถ้า laser ไปเจออะไรซักอย่างข้อมูลจะเก็บอยุ๋ที่ตัวแปร hits
            {
                Pose pose = hits[0].pose;
                if(objectInstance == null)
                {
                    objectInstance = Instantiate<GameObject>(objectToplacePrefab, pose.position, pose.rotation); //ทำการสร้าง object ตามตำแหน่งที่นิน้วจิ้มไป อันนี้สร้างรอบแรกก
                }
                else
                {
                    objectInstance.transform.SetPositionAndRotation(pose.position, pose.rotation);
                    
                }
            }
        }
    }
}

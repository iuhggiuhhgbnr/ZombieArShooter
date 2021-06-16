using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class BlendShapeTracking : MonoBehaviour
{
    public GameObject hitPoint;  //ตำแหน่งที่ผูกเข้ากับหน้า
    public Vector3 pointoffet;  //ผูกกับจุดที่จะขยับ ปรับ offest ตาม face ที่เราขยับ
    private ARFace face;

    void Start()
    {
        face = GetComponent<ARFace>();
    }

    private void OnEnable()
    {
        face.updated += OnUpdated;
    }
    private void OnDisable()
    {
        face.updated -= OnUpdated;
    }

    void OnUpdated(ARFaceUpdatedEventArgs eventArgs)
    {
        hitPoint.transform.position = transform.position - pointoffet;
    }
    
}

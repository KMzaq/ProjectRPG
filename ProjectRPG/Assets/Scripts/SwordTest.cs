using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SwordTest : MonoBehaviour
{
    [System.Serializable]
    public struct SwordTransform
    {
        public Vector3 position;
        public Vector3 rotation;
    }

    public List<SwordTransform> sworldTransforms;
    int curCount = 0;

    bool isPlayed = false;

    GameObject sword;

    void Start()
    {
        sword = this.gameObject;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Play();
            Debug.Log(sword.transform.rotation);
        }

        if (isPlayed)
        {
            if (curCount == sworldTransforms.Count) isPlayed = false;
        }
    }

    void Play()
    {
        if (isPlayed) return;
        if (sworldTransforms.Count == 0) return;

        curCount = 0;
        isPlayed = true;
        sword.transform.position = sworldTransforms[0].position;
        sword.transform.rotation = Quaternion.Euler(sworldTransforms[0].rotation);
    }
}

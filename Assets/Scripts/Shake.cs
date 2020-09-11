using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public GameObject cam;

    private void Start()
    {
        cam = GameObject.Find("CM vcam1");
    }
    public IEnumerator shake(float duration, float magnitute)
    {
        Vector3 originalpos = cam.transform.localPosition;
        float elapsed = 0.0f;

        while(elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitute;
            float y = Random.Range(-1f, 1f) * magnitute;

            cam.transform.localPosition = new Vector3(x, y, originalpos.z);

            elapsed += Time.deltaTime;
            yield return null;
        }

        cam.transform.localPosition = originalpos;
    }
}

using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Lane : ExMono {

    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(this.transform.position - new Vector3(100, 0, 0), this.transform.position + new Vector3(100, 0, 0), new Color(1, 0, 1, 0.5f));
    }
    void OnDrawGizmos() {

    }
}

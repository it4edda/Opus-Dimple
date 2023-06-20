using UnityEngine;

public class BodyConnection : MonoBehaviour
{
    [SerializeField] LineRenderer lineRenderer;
    [SerializeField] Transform    target;
    [SerializeField] Transform    target2;
    //ADD JOINTS
    void Update()
    {
        Vector3 start = target.position;
        Vector3 end   = target2.position;

        for (var i = 0; i < lineRenderer.positionCount; i++)
        {
            if (i == 0) lineRenderer.SetPosition(0, end);
            lineRenderer.SetPosition(i, start + (end - start) / lineRenderer.positionCount * i);
        }
    }
}

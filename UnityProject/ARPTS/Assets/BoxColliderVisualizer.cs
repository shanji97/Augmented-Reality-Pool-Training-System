
#if UNITY_EDITOR || DEVELOPMENT_BUILD
using UnityEngine;
[ExecuteInEditMode]
public class BoxColliderVisualizer : MonoBehaviour
{
    public Color gizmoColor = Color.green; // Color of the collider box
    private BoxCollider boxCollider;

    private void OnDrawGizmos()
    {
        boxCollider = GetComponent<BoxCollider>();
        if (boxCollider == null) return;

        Gizmos.color = gizmoColor;

        // Get collider world position & size
        Vector3 center = boxCollider.transform.position + boxCollider.center;
        Vector3 size = boxCollider.size;

        // Apply object scale
        Vector3 scaledSize = new Vector3(
            size.x * transform.lossyScale.x,
            size.y * transform.lossyScale.y,
            size.z * transform.lossyScale.z
        );

        // Draw Wireframe Cube
        Gizmos.matrix = Matrix4x4.TRS(center, transform.rotation, Vector3.one);
        Gizmos.DrawWireCube(Vector3.zero, scaledSize);
    }
}
#endif

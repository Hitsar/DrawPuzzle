using UnityEngine;

namespace Script
{
    public class FinishChecker : MonoBehaviour
    {
        private LineRenderer _lineRenderer;

        private void Start() => _lineRenderer = GetComponentInParent<LineRenderer>();

        public bool LineComeFinish(DrawingLine drawingLine)
        {
            Vector3 lastPoint = _lineRenderer.GetPosition(_lineRenderer.positionCount - 1);

            if (Physics2D.OverlapPoint(lastPoint).gameObject.TryGetComponent(out FinishChecker finish))
            {
                if (finish == this)
                    return true;
            }
            drawingLine.Clear();
            return false;
        }
    }
}
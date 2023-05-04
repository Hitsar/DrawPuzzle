using UnityEngine;

namespace Script
{
    public class FinishChecker : MonoBehaviour
    {
        private LineRenderer _lineRenderer;

        private void Start() => _lineRenderer = GetComponentInParent<LineRenderer>();

        public bool LineComeFinish()
        {
            Vector3 lastPoint = _lineRenderer.GetPosition(_lineRenderer.positionCount - 1);
            if (Physics2D.OverlapPoint(lastPoint) == null)
                return false;
            else if (Physics2D.OverlapPoint(lastPoint).TryGetComponent(out FinishChecker finish) && finish == this)
                return true;
            
            return false;
        }
    }
}
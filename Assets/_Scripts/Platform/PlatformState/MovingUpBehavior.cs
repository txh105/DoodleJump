using DG.Tweening;
using UnityEngine;

public class MovingUpBehavior : MonoBehaviour, IMovable
{
    private bool _isDestroyed = false;
    public void Move(Transform trans, float duration)
    {
        if (!_isDestroyed)
        {
            trans.DOMove(new Vector2(trans.position.x, -trans.position.y), duration)
                .SetEase(Ease.Linear)
                .SetLoops(-1, LoopType.Yoyo)
                .OnKill(() => _isDestroyed = true);
        }
    }
}

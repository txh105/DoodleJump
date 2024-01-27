using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class MovePlatform : BaseState
{
    public override void MovePlatformUp(Transform trans, float duration)
    {
        trans.DOMove(new Vector2(trans.position.x, -trans.position.y), duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
    public override void MovePlatformRight(Transform trans, float duration)
    {
        trans.DOMove(new Vector2(-trans.position.x, trans.position.y), duration).SetEase(Ease.Linear).SetLoops(-1, LoopType.Yoyo);
    }
}
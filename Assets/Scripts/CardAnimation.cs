using UnityEngine;
using DG.Tweening;

public class CardAnimation : MonoBehaviour
{
    public GameObject cardObject;
    public Vector3 sizeMultiplier = new Vector3(1.2f, 1.2f, 1.2f); //scale-up on hover

    public void HoverEffect(GameObject card)
    {
        card.transform.DOKill();
        Sequence hoverSequence = DOTween.Sequence();

        //Shake after hover
        hoverSequence.Append(card.transform.DOScale(sizeMultiplier, 0.25f).SetEase(Ease.OutQuad))
                     .Join(card.transform.DOShakeRotation(.5f, 5f, 20, 90f)); 
    }

    public void ReturnToOriginalState(GameObject card)
    {
        card.transform.DOKill();
        Sequence returnSequence = DOTween.Sequence();

        //Goes back to being unflipped 
        returnSequence.Append(card.transform.DOScale(Vector3.one, 0.25f).SetEase(Ease.InOutQuad))
                      .Join(card.transform.DORotate(Vector3.zero, 0.25f).SetEase(Ease.InOutQuad));
    }

    public void FlipCard(GameObject card)
    {
        card.transform.DOKill();
        Sequence flipSequence = DOTween.Sequence();

        //Flip the cards to the right
        flipSequence.Append(card.transform.DORotate(new Vector3(0, 180, 0), 0.3f, RotateMode.LocalAxisAdd).SetEase(Ease.InOutQuad));
    }
}

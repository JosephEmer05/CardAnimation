using UnityEngine;

public class CardObject : MonoBehaviour
{
    public CardAnimation cardAnim;
    private Collider cardCollider;
    public bool isFlipped;

    private void Start()
    {
        cardCollider = GetComponent<Collider>();
    }

    private void OnMouseEnter()
    {
        cardAnim.HoverEffect(gameObject);
    }

    private void OnMouseExit()
    {
        cardAnim.ReturnToOriginalState(gameObject);
    }

    private void OnMouseDown()
    {
        cardAnim.FlipCard(gameObject);
        isFlipped = !isFlipped;
    }
}

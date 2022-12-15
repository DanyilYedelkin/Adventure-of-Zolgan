using UnityEngine;

public class Chest : Collectable
{
    public Sprite emptyChest;
    public int pesosAmount = 5;
    protected override void OnCollect()
    {
        if (!collected)
        {
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            GameManager.instance.pesos += pesosAmount;
            // +5 golds
            GameManager.instance.ShowText("+" + pesosAmount + " golds!", 30, Color.yellow, transform.position, Vector3.up * 25, 1.5f);
        }
    }
}

using UnityEngine;

public class Life : ItemBase
{
    [SerializeField] int _recoverLife = 1;
    public override void Activate()
    {
        FindObjectOfType<GameManager>().AddLife(_recoverLife);
    }
}

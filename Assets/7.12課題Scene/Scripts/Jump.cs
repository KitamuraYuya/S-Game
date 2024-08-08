using UnityEngine;

public class Jump :ItemBase
{
    [SerializeField] PlayerController Player;
    [SerializeField] float _jumpSpeed = 1f;
    public override void Activate()
    {
        Player._jumpSpeed = Player._jumpSpeed * _jumpSpeed;
    }
}

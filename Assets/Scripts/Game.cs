using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Player _player;

    [SerializeField] private List<Box> _boxList;

    [SerializeField] private VirtualCursor _cursor;

    private void Awake()
    {
        _player.SetPrimaryShooter(new RayShooter(new InteractEffect()));
        _player.SetSecondaryShooter(new RayShooter(new InteractEffect()));

        foreach (Box box in _boxList)
            box.Inizialize(new DragAndDrop(box.transform, _cursor.transform));
    }
}

using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public List<Collectible> collected = new List<Collectible>();

    void Awake() => instance = this;
    public void AddCollected(Collectible c) => collected.Add(c);
}

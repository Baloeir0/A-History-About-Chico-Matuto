using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool Isgameactive;
    public static GameManager Instance;
    [SerializeField] private GameObject _Mountain;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        Isgameactive = true;
    }
}

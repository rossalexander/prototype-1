using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private readonly Vector3 _offset = new Vector3(0, 5, -7);

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        // Offset camera
        transform.position = player.transform.position + _offset;
    }
}
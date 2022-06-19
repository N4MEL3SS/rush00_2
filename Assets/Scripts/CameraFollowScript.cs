using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{
    public PlayerMoveScript playerScript;
    public float shiftCameraRotation = 1f;
    
    private Transform _player;
    private Vector3 _position;

    // Start is called before the first frame update
    private void Start()
    {
        _player = FindObjectOfType<PlayerMoveScript>().transform;
    }

    // Update is called once per frame
    private void Update()
    {
        CameraFollow();
        CameraRotate();
    }

    private void CameraFollow()
    {
        _position = _player.transform.position;
        transform.position = new Vector3(_position.x, _position.y, _position.z - 10f);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            _position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
                Input.mousePosition.y, Input.mousePosition.z - Camera.main.transform.position.z)); 
            transform.position = new Vector3(_position.x / 2, _position.y / 2, _position.z - 10f);
            transform.position = new Vector3(_position.x, _position.y, _position.z - 10f);
        }
    }

    private void CameraRotate()
    {
        var rotation = playerScript.x * shiftCameraRotation;
        transform.eulerAngles = new Vector3(0, 0, rotation);
    }
}

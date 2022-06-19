using UnityEditor.VersionControl;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
	private Animator _animator;

	private void Awake()
	{
		_animator = GetComponent<Animator>();
	}
	
	public States State
	{
		set => _animator.SetInteger("state", (int)value);
	}
}

public enum States
{
	Idle,
	MoveUp,
	MoveDown
}

using UnityEngine;
using System.Collections;

public class TimingHolder {

	private float x, y, z;
	private long tick;
	private bool value;

	public TimingHolder(float x, float y, float z, long tick, bool value)
	{
		this.x = x;
		this.y = y;
		this.z = z;
		this.tick = tick;
		this.value = value;
	}
		

	public float X {
		get;
		set;
	}
	public float Y
	{
		get;
		set; 
	}
	public float Z
	{
		get;
		set;
	}
	public long Tick
	{
		get;
		set;
	}
	public bool Value
	{
		get;
		set;
	}


}

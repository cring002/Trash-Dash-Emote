﻿using UnityEngine;

public class AllLaneObstacle: Obstacle
{
	public override void Spawn(TrackSegment segment, float t, int l)
	{
		Vector3 position;
		Quaternion rotation;
		segment.GetPointAt(t, out position, out rotation);
		GameObject obj = Instantiate(gameObject, position, rotation);
		obj.transform.SetParent(segment.objectRoot, true);
	}
}

﻿using System.Collections.Generic;
using Verse;

namespace RedistHeat
{
	public class PlaceWorker_DuctIntersection : PlaceWorker
	{
		public override void DrawGhost(ThingDef def, IntVec3 center, IntRot rot)
		{
			var vec = new IntVec3[4];
			for (var i = 0; i < 4; i++)
			{
				vec[i] = center + GenAdj.CardinalDirections[i];
			}
			GenDraw.DrawFieldEdges(new List<IntVec3> { vec[0], vec[2] }, GenTemperature.ColorRoomHot);
			GenDraw.DrawFieldEdges(new List<IntVec3> { vec[1], vec[3] }, GenTemperature.ColorRoomCold);
		}
		public override AcceptanceReport AllowsPlacing(EntityDef def, IntVec3 center, IntRot rot)
		{
			return true;
		}
	}
}
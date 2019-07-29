using LandShips.Redirection;
using UnityEngine;

namespace LandShips.Detours
{
    [TargetType(typeof(TerrainManager))]
    public class TerrainManagerDetour : TerrainManager
    {
        [RedirectMethod]
        public new float SampleBlockHeightSmoothWithWater(Vector3 worldPos, bool timeLerp, float waterOffset, out bool hasWater)
        {
            var waterLevel = this.SampleBlockHeightSmoothWithWater((float)((double)worldPos.x / 16.0 + 540.0), (float)((double)worldPos.z / 16.0 + 540.0), timeLerp, waterOffset, out hasWater) * (1f / 64f);
            hasWater = true;
            return waterLevel;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuMech;
using KRPC;
using KRPC.Service.Attributes;
using KRPC.Service;
using KRPCSpaceCenter;

namespace krpcmj
{
    public static partial class krpcmj
    {
        [KRPCProcedure]
        public static double NextTimeAlt(KRPCSpaceCenter.Services.Vessel ves, double alt)
        {return ves.InternalVessel.orbit.NextTimeOfRadius(Planetarium.GetUniversalTime(), alt);}

        [KRPCProcedure]
        public static double closestAppTime(KRPCSpaceCenter.Services.Vessel ves)
        {
                Vessel target = ves.InternalVessel.targetObject as Vessel;
                return ves.InternalVessel.orbit.NextClosestApproachTime(target.orbit, Planetarium.GetUniversalTime());
        }

        [KRPCProcedure]
        public static double closestAppDist(KRPCSpaceCenter.Services.Vessel ves)
        {
            Vessel target = ves.InternalVessel.targetObject as Vessel;
            return ves.InternalVessel.orbit.NextClosestApproachDistance(target.orbit, Planetarium.GetUniversalTime());
        }
        
        [KRPCProcedure]
        public static double relativeInc(KRPCSpaceCenter.Services.Vessel ves)
        {
            Vessel target = ves.InternalVessel.targetObject as Vessel;
            return ves.InternalVessel.orbit.RelativeInclination(target.orbit);
        }

        [KRPCProcedure]
        public static double timeAn(KRPCSpaceCenter.Services.Vessel ves)
        { return ves.InternalVessel.orbit.TimeOfAscendingNodeEquatorial(Planetarium.GetUniversalTime()); }

        [KRPCProcedure]
        public static double timeDn(KRPCSpaceCenter.Services.Vessel ves)
        {return ves.InternalVessel.orbit.TimeOfDescendingNodeEquatorial(Planetarium.GetUniversalTime());}

        [KRPCProcedure]
        public static double ClosestAppVel(KRPCSpaceCenter.Services.Vessel ves)
        {
                Vector3d dV = OrbitalManeuverCalculator.DeltaVToMatchVelocities(ves.InternalVessel.orbit, Planetarium.GetUniversalTime(), ves.InternalVessel.targetObject.GetOrbit());
                return dV.magnitude;
        }

        [KRPCProcedure]
        public static double relativeVel(KRPCSpaceCenter.Services.Vessel ves)
        {
                Vessel target = ves.InternalVessel.targetObject as Vessel;
                Vector3d deltav = OrbitalManeuverCalculator.DeltaVToMatchVelocities(ves.InternalVessel.orbit, Planetarium.GetUniversalTime(), target.orbit);
                return deltav.magnitude;
        }

        [KRPCProcedure]
        public static double phaseAngle(KRPCSpaceCenter.Services.Vessel ves)
        {return ves.InternalVessel.orbit.PhaseAngle(ves.InternalVessel.targetObject.GetOrbit(), Planetarium.GetUniversalTime()); }

        [KRPCProcedure]
        public static string biome(KRPCSpaceCenter.Services.Vessel ves)
        {return ves.InternalVessel.mainBody.BiomeMap.GetAtt(ves.InternalVessel.latitude * Math.PI / 180d, ves.InternalVessel.longitude * Math.PI / 180d).name; }

    }


}
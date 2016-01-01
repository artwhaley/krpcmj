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
    public static partial class krpcmj   //Collection of useful bits of data to have, but not gathered via mechjeb access.  Probably ought to contribute some of these to Spacecenter.Services.Orbit ?
    {
        /// <summary>
        /// Returns the next time a Vessel's orbit crosses a given altitude  
        /// </summary>
        [KRPCProcedure]
        public static double NextTimeAlt(KRPCSpaceCenter.Services.Vessel ves, double alt)
        {return ves.InternalVessel.orbit.NextTimeOfRadius(Planetarium.GetUniversalTime(), alt);}

        /// <summary>
        /// Returns Vessel's time of closest approach to it's target   
        /// </summary>
        [KRPCProcedure]
        public static double closestAppTime(KRPCSpaceCenter.Services.Vessel ves)
        {
                Vessel target = ves.InternalVessel.targetObject as Vessel;
                return ves.InternalVessel.orbit.NextClosestApproachTime(target.orbit, Planetarium.GetUniversalTime());
        }

        /// <summary>
        /// Returns Vessel's distance at closest approach to it's target   
        /// </summary>
        [KRPCProcedure]
        public static double closestAppDist(KRPCSpaceCenter.Services.Vessel ves)
        {
            Vessel target = ves.InternalVessel.targetObject as Vessel;
            return ves.InternalVessel.orbit.NextClosestApproachDistance(target.orbit, Planetarium.GetUniversalTime());
        }

        /// <summary>
        /// Returns relative inclination between vessel and it's target   
        /// </summary>
        [KRPCProcedure]
        public static double relativeInc(KRPCSpaceCenter.Services.Vessel ves)
        {
            Vessel target = ves.InternalVessel.targetObject as Vessel;
            return ves.InternalVessel.orbit.RelativeInclination(target.orbit);
        }

        /// <summary>
        /// Returns the time of next Equatorial Ascending Node   
        /// </summary>
        [KRPCProcedure]
        public static double timeAn(KRPCSpaceCenter.Services.Vessel ves)
        { return ves.InternalVessel.orbit.TimeOfAscendingNodeEquatorial(Planetarium.GetUniversalTime()); }

        /// <summary>
        /// Returns the time of next Euatorial Descending Node   
        /// </summary>
        [KRPCProcedure]
        public static double timeDn(KRPCSpaceCenter.Services.Vessel ves)
        {return ves.InternalVessel.orbit.TimeOfDescendingNodeEquatorial(Planetarium.GetUniversalTime());}

        /// <summary>
        /// Returns the velocity difference between vessel and it's target at closest approach   
        /// </summary>
        [KRPCProcedure]
        public static double ClosestAppVel(KRPCSpaceCenter.Services.Vessel ves)
        {
                Vector3d dV = OrbitalManeuverCalculator.DeltaVToMatchVelocities(ves.InternalVessel.orbit, Planetarium.GetUniversalTime(), ves.InternalVessel.targetObject.GetOrbit());
                return dV.magnitude;
        }

        /// <summary>
        /// Returns the difference in velocity now between vessel and target   
        /// </summary>
        [KRPCProcedure]
        public static double relativeVel(KRPCSpaceCenter.Services.Vessel ves)
        {
                Vessel target = ves.InternalVessel.targetObject as Vessel;
                Vector3d deltav = OrbitalManeuverCalculator.DeltaVToMatchVelocities(ves.InternalVessel.orbit, Planetarium.GetUniversalTime(), target.orbit);
                return deltav.magnitude;
        }

        /// <summary>
        /// Should return the phase angle of vessel in reference to target...  but...  doesn't.  Needs work   
        /// </summary>
        [KRPCProcedure]
        public static double phaseAngle(KRPCSpaceCenter.Services.Vessel ves)
        {return ves.InternalVessel.orbit.PhaseAngle(ves.InternalVessel.targetObject.GetOrbit(), Planetarium.GetUniversalTime()); }

        /// <summary>
        /// Returns the biome currently underneath vessel
        /// </summary>
        [KRPCProcedure]
        public static string biome(KRPCSpaceCenter.Services.Vessel ves)
        {return ves.InternalVessel.mainBody.BiomeMap.GetAtt(ves.InternalVessel.latitude * Math.PI / 180d, ves.InternalVessel.longitude * Math.PI / 180d).name; }

    }


}
using System;
using System.Collections.Generic;
using System.Collections;
using MuMech;
using KRPC.Service.Attributes;


namespace krpcmj
{
    public static partial class krpcmj   //Collection of useful bits of data to have, but not necessarily gathered via mechjeb access.  Probably ought to contribute some of these to Spacecenter.Services.Orbit ?
    {


        /// <summary>
        /// Returns the DV stats for the mjvessel  
        /// </summary>
        [KRPCProcedure]
        public static IList<IList<double>> DVStats()
        {
            IList<IList<double>> stats = new List<IList<double>>();
            MechJebCore activejeb = GetJeb();
            if (activejeb != null)
            {
                MechJebModuleStageStats activestats = activejeb.GetComputerModule("MechJebModuleStageStats") as MechJebModuleStageStats;
                if (activestats != null)
                {

                    activestats.RequestUpdate(activejeb);
                    int len = activestats.atmoStats.Length;
                    for (int i = 0; i < len; i++)
                    {
                        IList<double> stage = new List<double>();
                        stage.Add(activestats.atmoStats[i].deltaV);
                        stage.Add(activestats.vacStats[i].deltaV);
                        stage.Add(activestats.atmoStats[i].StartTWR(1));
                        stage.Add(activestats.vacStats[i].StartTWR(1));
                        stage.Add(activestats.atmoStats[i].deltaTime);
                        stats.Add(stage);
                    }
                }
            }

                        return stats;
        }

        /// <summary>
        /// Returns the next time a Vessel's orbit crosses a given altitude  
        /// </summary>
        [KRPCProcedure]
        public static double NextTimeAlt(double alt)

        {

            double timeraw =  mjvessel.orbit.NextTimeOfRadius(Planetarium.GetUniversalTime(), (alt+APVessel.Orbit.Body.EquatorialRadius));
            return timeraw - Planetarium.GetUniversalTime();
        }

        /// <summary>
        /// Returns Vessel's time of closest approach to it's target   
        /// </summary>
        [KRPCProcedure]
        public static double ClosestAppTime()
        {
                Vessel target = mjvessel.targetObject as Vessel;
                return mjvessel.orbit.NextClosestApproachTime(target.orbit, Planetarium.GetUniversalTime())-Planetarium.GetUniversalTime();
        }

        /// <summary>
        /// Returns Vessel's distance at closest approach to it's target   
        /// </summary>
        [KRPCProcedure]
        public static double ClosestAppDist()
        {
            Vessel target = mjvessel.targetObject as Vessel;
            return mjvessel.orbit.NextClosestApproachDistance(target.orbit, Planetarium.GetUniversalTime());
        }

        /// <summary>
        /// Returns relative inclination between vessel and it's target   
        /// </summary>
        [KRPCProcedure]
        public static double RelativeInc()
        {
            Vessel target = mjvessel.targetObject as Vessel;
            return mjvessel.orbit.RelativeInclination(target.orbit);
        }
        /// <summary>
        /// Checks if there is an Equatorial Ascending Node  
        /// </summary>
        [KRPCProcedure]
        public static bool IsEqAn()
        { return mjvessel.orbit.AscendingNodeEquatorialExists(); }

        /// <summary>
        /// Checks if there is an Equatorial Descending Node Node   
        /// </summary>
        [KRPCProcedure]
        public static bool IsEqDn()
        { return mjvessel.orbit.DescendingNodeEquatorialExists(); }
        /// <summary>
        /// Returns the time until Equatorial Ascending Node   
        /// </summary>
        [KRPCProcedure]
        public static double TimeEqAn()
        { return mjvessel.orbit.TimeOfAscendingNodeEquatorial(Planetarium.GetUniversalTime()) - Planetarium.GetUniversalTime();}

        /// <summary>
        /// Returns the time until Euatorial Descending Node   
        /// </summary>
        [KRPCProcedure]
        public static double TimeEqDn()
        {return mjvessel.orbit.TimeOfDescendingNodeEquatorial(Planetarium.GetUniversalTime()) - Planetarium.GetUniversalTime();}


        /// <summary>
        /// Checks if there is an Equatorial Ascending Node  
        /// </summary>
        [KRPCProcedure]
        public static bool IsTgtAn()
        { return mjvessel.orbit.AscendingNodeExists(mjvessel.targetObject.GetOrbit()); }

        /// <summary>
        /// Checks if there is an Equatorial Descending Node Node   
        /// </summary>
        [KRPCProcedure]
        public static bool IsTgtDn()
        { return mjvessel.orbit.DescendingNodeExists(mjvessel.targetObject.GetOrbit()); }
        /// <summary>
        /// Returns the time until next Equatorial Ascending Node   
        /// </summary>
        [KRPCProcedure]
        public static double TimeTgtAn()
        { return mjvessel.orbit.TimeOfAscendingNode(mjvessel.targetObject.GetOrbit(), Planetarium.GetUniversalTime())-Planetarium.GetUniversalTime(); }

        /// <summary>
        /// Returns the time until next Euatorial Descending Node   
        /// </summary>
        [KRPCProcedure]
        public static double TimeTgtDn()
        { return mjvessel.orbit.TimeOfDescendingNode(mjvessel.targetObject.GetOrbit(), Planetarium.GetUniversalTime()) - Planetarium.GetUniversalTime() ; }

        /// <summary>
        /// Returns the velocity difference between vessel and it's target at closest approach   
        /// </summary>
        [KRPCProcedure]
        public static double ClosestAppVel()
        {
                Vector3d dV = OrbitalManeuverCalculator.DeltaVToMatchVelocities(mjvessel.orbit, Planetarium.GetUniversalTime(), mjvessel.targetObject.GetOrbit());
                return dV.magnitude;
        }

        /// <summary>
        /// Returns the difference in velocity now between vessel and target   
        /// </summary>
        [KRPCProcedure]
        public static double RelativeVel()
        {
                Vessel target = mjvessel.targetObject as Vessel;
                Vector3d deltav = OrbitalManeuverCalculator.DeltaVToMatchVelocities(mjvessel.orbit, Planetarium.GetUniversalTime(), target.orbit);
                return deltav.magnitude;
        }

        /// <summary>
        /// Should return the phase angle of vessel in reference to target...  but...  doesn't.  Needs work   
        /// </summary>
        [KRPCProcedure]
        public static double PhaseAngle()
        {return mjvessel.orbit.PhaseAngle(mjvessel.targetObject.GetOrbit(), Planetarium.GetUniversalTime()); }

        /// <summary>
        /// Returns the biome currently underneath vessel
        /// </summary>
        [KRPCProcedure]
        public static string Biome()
        {return mjvessel.mainBody.BiomeMap.GetAtt(mjvessel.latitude * Math.PI / 180d, mjvessel.longitude * Math.PI / 180d).name; }

    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuMech;
using KRPC;
using KRPC.Service.Attributes;
using KRPC.Service;
using KRPC.SpaceCenter;

namespace krpcmj
{
    public static partial class krpcmj   //Collection of useful bits of data to have..  Probably ought to contribute some of these that don't rely on MechJeb to Spacecenter.Services.Orbit ?
    {



        /// <summary>
        /// Returns the deltaV and TWR data for every stage of vessel
        /// </summary>
        [KRPCProperty]  
        public static IList<IList<double>> dvstats
        {
            get
            {
                IList<IList<double>> A =new List<IList<double>>();
                
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
                            IList<double> B = new List<double>();
                            B.Add(activestats.atmoStats[i].deltaV);
                            B.Add(activestats.atmoStats[i].StartTWR(1));
                            B.Add(activestats.vacStats[i].deltaV);
                            B.Add(activestats.vacStats[i].StartTWR(1));
                            B.Add(activestats.vacStats[i].deltaTime);
                            A.Add(B);
                           
                        }




                    }
                }
                return A;
            }

        }

        /// <summary>
        /// Returns the next time a Vessel's orbit crosses a given altitude  
        /// </summary>
        [KRPCProcedure]
        public static double NextTimeAlt(double alt)
        {return mjvessel.orbit.NextTimeOfRadius(Planetarium.GetUniversalTime(), alt);}

        /// <summary>
        /// Returns Vessel's time of closest approach to it's target   
        /// </summary>
        [KRPCProcedure]
        public static double closestAppTime()
        {
                
                Vessel target = mjvessel.targetObject as Vessel;
                return mjvessel.orbit.NextClosestApproachTime(target.orbit, Planetarium.GetUniversalTime());
        }

        /// <summary>
        /// Returns Vessel's distance at closest approach to it's target   
        /// </summary>
        [KRPCProcedure]
        public static double closestAppDist()
        {
            Vessel target = mjvessel.targetObject as Vessel;
            return mjvessel.orbit.NextClosestApproachDistance(target.orbit, Planetarium.GetUniversalTime());
        }

        /// <summary>
        /// Returns relative inclination between vessel and it's target   
        /// </summary>
        [KRPCProcedure]
        public static double relativeInc()
        {
            Vessel target = mjvessel.targetObject as Vessel;
            return mjvessel.orbit.RelativeInclination(target.orbit);
        }
        /// <summary>
        /// Returns if vessel and target have Ascending Node or not
        /// </summary>
        [KRPCProcedure]
        public static bool ExistsAnTarget()
        {
            Vessel target = mjvessel.targetObject as Vessel;
            return OrbitExtensions.AscendingNodeExists(mjvessel.orbit, target.orbit);
        }
        /// <summary>
        /// Returns if vessel and target have Descending Node or not
        /// </summary>
        [KRPCProcedure]
        public static bool ExistsDnTarget()
        {
            Vessel target = mjvessel.targetObject as Vessel;
            return OrbitExtensions.DescendingNodeExists(mjvessel.orbit, target.orbit);
        }
        /// <summary>
        /// Returns time of next Ascending Node with Target's Orbit
        /// </summary>
        [KRPCProcedure]
        public static double timeAnTarget()
        {
            Vessel target = mjvessel.targetObject as Vessel;
            return mjvessel.orbit.TimeOfAscendingNode(target.orbit, Planetarium.GetUniversalTime());

        }
        /// <summary>
        /// Returns time of next Descending Node with Target's Orbit   
        /// </summary>
        [KRPCProcedure]
        public static double timeDnTarget()
        {
            Vessel target = mjvessel.targetObject as Vessel;
            return mjvessel.orbit.TimeOfDescendingNode(target.orbit, Planetarium.GetUniversalTime());
        }
        /// <summary>
        /// Returns if vessel and target have Ascending Node or not
        /// </summary>
        [KRPCProcedure]
        public static bool ExistsAn()
        {
            Vessel target = mjvessel.targetObject as Vessel;
            return OrbitExtensions.AscendingNodeEquatorialExists(mjvessel.orbit);
            
        }
        /// <summary>
        /// Returns if vessel and target have Descending Node or not
        /// </summary>
        [KRPCProcedure]
        public static bool ExistsDn()
        {
            Vessel target = mjvessel.targetObject as Vessel;
            return OrbitExtensions.DescendingNodeEquatorialExists(mjvessel.orbit);
        }

        /// <summary>
        /// Returns the time of next Equatorial Ascending Node   
        /// </summary>
        [KRPCProcedure]
        public static double timeAn()
        { return mjvessel.orbit.TimeOfAscendingNodeEquatorial(Planetarium.GetUniversalTime()); }

        /// <summary>
        /// Returns the time of next Euatorial Descending Node   
        /// </summary>
        [KRPCProcedure]
        public static double timeDn()
        {return mjvessel.orbit.TimeOfDescendingNodeEquatorial(Planetarium.GetUniversalTime());}

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
        public static double relativeVel()
        {
                Vessel target = mjvessel.targetObject as Vessel;
                Vector3d deltav = OrbitalManeuverCalculator.DeltaVToMatchVelocities(mjvessel.orbit, Planetarium.GetUniversalTime(), target.orbit);
                return deltav.magnitude;
        }

        /// <summary>
        /// Should return the phase angle of vessel in reference to target...  but...  doesn't.  Needs work   
        /// </summary>
        [KRPCProcedure]
        public static double phaseAngle()
        {return mjvessel.orbit.PhaseAngle(mjvessel.targetObject.GetOrbit(), Planetarium.GetUniversalTime()); }

        /// <summary>
        /// Returns the biome currently underneath vessel
        /// </summary>
        [KRPCProcedure]
        public static string biome()
        {return mjvessel.mainBody.BiomeMap.GetAtt(mjvessel.latitude * Math.PI / 180d, mjvessel.longitude * Math.PI / 180d).name; }



    }


}
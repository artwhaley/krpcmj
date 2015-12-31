using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MuMech;
using KRPC;
using KRPC.Service.Attributes;
using KRPC.Service;

namespace krpcmj
{

    public static partial class krpcmj
    {
        [KRPCProcedure]
        public static void ExecuteNextNode()
        {
            MechJebCore activejeb = GetJeb();
            if (activejeb != null)
            {
                MechJebModuleNodeExecutor activenode = activejeb.GetComputerModule("MechJebModuleNodeExecutor") as MechJebModuleNodeExecutor;
                if (activenode != null)
                {
                    activenode.ExecuteOneNode(activejeb);
                }
            }
        }
        [KRPCProcedure]
        public static void ExecuteAllNodes()
        {
            MechJebCore activejeb = GetJeb();
            if (activejeb != null)
            {
                MechJebModuleNodeExecutor activenode = activejeb.GetComputerModule("MechJebModuleNodeExecutor") as MechJebModuleNodeExecutor;
                if (activenode != null)
                {
                    activenode.ExecuteAllNodes(activejeb);
                }
            }
        }
        [KRPCProcedure]
        public static void AbortExecution()
        {
            MechJebCore activejeb = GetJeb();
            if (activejeb != null)
            {
                MechJebModuleNodeExecutor activenode = activejeb.GetComputerModule("MechJebModuleNodeExecutor") as MechJebModuleNodeExecutor;
                if (activenode != null)
                {
                    activenode.Abort();
                }
            }
        }

        [KRPCProcedure]
        public static void mpMatchplanes()
        {
            MechJebCore activejeb = GetJeb();
            if (activejeb != null)
            {
                Vessel vessel = activejeb.vessel;
                Vessel target = activejeb.vessel.targetObject as Vessel;
                double time = Planetarium.GetUniversalTime();
                Vector3d deltav;
                double gotime = 0;

                if (vessel.orbit.AscendingNodeExists(target.orbit))
                {
                    if (vessel.orbit.TimeOfAscendingNode(target.orbit, time) < vessel.orbit.TimeOfDescendingNode(target.orbit, time))
                    {deltav = OrbitalManeuverCalculator.DeltaVAndTimeToMatchPlanesAscending(vessel.orbit, target.orbit, time, out gotime);}
                    else{deltav = OrbitalManeuverCalculator.DeltaVAndTimeToMatchPlanesDescending(vessel.orbit, target.orbit, time, out gotime);}
                }
                else { deltav = OrbitalManeuverCalculator.DeltaVAndTimeToMatchPlanesDescending(vessel.orbit, target.orbit, time, out gotime); }
                vessel.PlaceManeuverNode(vessel.orbit, deltav, gotime);
            }
        }

        [KRPCProcedure]
        public static void mpCirc(double time)
        {
            MechJebCore activejeb = GetJeb();
            if (activejeb != null)
            {
                Vector3d deltav = OrbitalManeuverCalculator.DeltaVToCircularize(activejeb.vessel.orbit, time);
                activejeb.vessel.PlaceManeuverNode(activejeb.vessel.orbit, deltav, time);
            }
        }

        [KRPCProcedure]
        public static void mpApa(double time, double apa)
        {
            MechJebCore activejeb = GetJeb();
            if (activejeb != null)
            {
                Vector3d deltav = OrbitalManeuverCalculator.DeltaVToChangeApoapsis(activejeb.vessel.orbit, time, apa);
                activejeb.vessel.PlaceManeuverNode(activejeb.vessel.orbit, deltav, time);
            }
        }

        [KRPCProcedure]
        public static void mpPea(double time, double pea)
        {
            MechJebCore activejeb = GetJeb();
            if (activejeb != null)
            {
                Vector3d deltav = OrbitalManeuverCalculator.DeltaVToChangePeriapsis(activejeb.vessel.orbit, time, pea);
                activejeb.vessel.PlaceManeuverNode(activejeb.vessel.orbit, deltav, time);
            }
        }

        [KRPCProcedure]
        public static void mpInc(double time, double inc)
        {
            MechJebCore activejeb = GetJeb();
            if (activejeb != null)
            {
                Vector3d deltav = OrbitalManeuverCalculator.DeltaVToChangeInclination(activejeb.vessel.orbit, time, inc);
                activejeb.vessel.PlaceManeuverNode(activejeb.vessel.orbit, deltav, time);
            }
        }

        [KRPCProcedure]
        public static void mpMatchVelocity(double time)
        {
            MechJebCore activejeb = GetJeb();
            if (activejeb != null)
            {
                Vessel target = activejeb.vessel.targetObject as Vessel;
                Vector3d deltav = OrbitalManeuverCalculator.DeltaVToMatchVelocities(activejeb.vessel.orbit, time, target.orbit);
                activejeb.vessel.PlaceManeuverNode(activejeb.vessel.orbit, deltav, time);
            }
        }

        [KRPCProcedure]
        public static void mpHohmann()
        {  
            MechJebCore activejeb = GetJeb();
            if (activejeb != null)
            {
                Vessel target = activejeb.vessel.targetObject as Vessel;
                double time = 0;
                Vector3d deltav = OrbitalManeuverCalculator.DeltaVAndTimeForHohmannTransfer(activejeb.vessel.orbit, target.orbit, Planetarium.GetUniversalTime(), out time);
                activejeb.vessel.PlaceManeuverNode(activejeb.vessel.orbit, deltav, time);
            }
        }

        [KRPCProcedure]
        public static void mpPlanet()
        {
            MechJebCore activejeb = GetJeb();
            if (activejeb != null)
            {
                CelestialBody target = activejeb.vessel.targetObject as CelestialBody;
                double time = 0;
                Vector3d deltav = OrbitalManeuverCalculator.DeltaVAndTimeForInterplanetaryLambertTransferEjection(activejeb.vessel.orbit, Planetarium.GetUniversalTime(), target.orbit, out time);
                activejeb.vessel.PlaceManeuverNode(activejeb.vessel.orbit, deltav, time);
            }
        }

     



    }

}
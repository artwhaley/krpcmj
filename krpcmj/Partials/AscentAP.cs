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
        [KRPCProperty]
        public static bool AscentAP
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleAscentAutopilot activeasc = activejeb.GetComputerModule("MechJebModuleAscentAutopilot") as MechJebModuleAscentAutopilot;
                    if (activeasc != null)
                    {
                        return activeasc.enabled;
                    }
                }return false;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleAscentAutopilot activeasc = activejeb.GetComputerModule("MechJebModuleAscentAutopilot") as MechJebModuleAscentAutopilot;
                    if (activeasc != null)
                    {
                        activeasc.enabled = value;
                    }
                }
            }
        }
        [KRPCProperty]
        public static double AscentAlt
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleAscentAutopilot activeasc = activejeb.GetComputerModule("MechJebModuleAscentAutopilot") as MechJebModuleAscentAutopilot;
                    if (activeasc != null)
                    {
                        return activeasc.desiredOrbitAltitude;
                    }
                }
                return 0.0;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleAscentAutopilot activeasc = activejeb.GetComputerModule("MechJebModuleAscentAutopilot") as MechJebModuleAscentAutopilot;
                    if (activeasc != null)
                    {
                        activeasc.desiredOrbitAltitude.val = value; 
                    
                    }
                }
            }
        }
        [KRPCProperty]
        public static double AscentInc
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleAscentAutopilot activeasc = activejeb.GetComputerModule("MechJebModuleAscentAutopilot") as MechJebModuleAscentAutopilot;
                    if (activeasc != null)
                    {
                        return activeasc.desiredInclination;
                    }
                }
                return 0.0;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleAscentAutopilot activeasc = activejeb.GetComputerModule("MechJebModuleAscentAutopilot") as MechJebModuleAscentAutopilot;
                    if (activeasc != null)
                    {
                        activeasc.desiredInclination = value;
                    }
                }
            }
        }
        [KRPCProperty]
        public static bool AscentLimitAOA
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleAscentAutopilot activeasc = activejeb.GetComputerModule("MechJebModuleAscentAutopilot") as MechJebModuleAscentAutopilot;
                    if (activeasc != null)
                    {
                        return activeasc.limitAoA;
                    }
                }
                return false;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleAscentAutopilot activeasc = activejeb.GetComputerModule("MechJebModuleAscentAutopilot") as MechJebModuleAscentAutopilot;
                    if (activeasc != null)
                    {
                        activeasc.limitAoA = value;
                    }
                }
            }
        }
        [KRPCProperty]
        public static double AscentMaxAOA
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleAscentAutopilot activeasc = activejeb.GetComputerModule("MechJebModuleAscentAutopilot") as MechJebModuleAscentAutopilot;
                    if (activeasc != null)
                    {
                        return activeasc.maxAoA.val;
                    }
                }
                return 0.0;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleAscentAutopilot activeasc = activejeb.GetComputerModule("MechJebModuleAscentAutopilot") as MechJebModuleAscentAutopilot;
                    if (activeasc != null)
                    {
                        activeasc.maxAoA.val= value;
                    }
                }
            }
        }
        [KRPCProperty]
        public static double AscenTurnRoll
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleAscentAutopilot activeasc = activejeb.GetComputerModule("MechJebModuleAscentAutopilot") as MechJebModuleAscentAutopilot;
                    if (activeasc != null)
                    {
                        return activeasc.turnRoll;
                    }
                }
                return 0.0;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleAscentAutopilot activeasc = activejeb.GetComputerModule("MechJebModuleAscentAutopilot") as MechJebModuleAscentAutopilot;
                    if (activeasc != null)
                    {
                        activeasc.turnRoll = value;
                    }
                }
            }
        }
        [KRPCProperty]
        public static double AscenClimbRoll
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleAscentAutopilot activeasc = activejeb.GetComputerModule("MechJebModuleAscentAutopilot") as MechJebModuleAscentAutopilot;
                    if (activeasc != null)
                    {
                        return activeasc.verticalRoll;
                    }
                }
                return 0.0;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleAscentAutopilot activeasc = activejeb.GetComputerModule("MechJebModuleAscentAutopilot") as MechJebModuleAscentAutopilot;
                    if (activeasc != null)
                    {
                        activeasc.verticalRoll = value;
                    }
                }
            }
        }
        [KRPCProperty]
        public static bool AscentForceRoll
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleAscentAutopilot activeasc = activejeb.GetComputerModule("MechJebModuleAscentAutopilot") as MechJebModuleAscentAutopilot;
                    if (activeasc != null)
                    {
                        return activeasc.forceRoll;
                    }
                }
                return false;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleAscentAutopilot activeasc = activejeb.GetComputerModule("MechJebModuleAscentAutopilot") as MechJebModuleAscentAutopilot;
                    if (activeasc != null)
                    {
                        activeasc.forceRoll = value;
                    }
                }
            }
        }

        [KRPCProcedure]
        public static void AscentNow(double Alt, float Inc)
        {
            MechJebCore activejeb = GetJeb();
            if (activejeb != null)
            {
                MechJebModuleAscentAutopilot activeasc = activejeb.GetComputerModule("MechJebModuleAscentAutopilot") as MechJebModuleAscentAutopilot;
                if (activeasc != null)
                {
                    activeasc.desiredOrbitAltitude.val = Alt;
                    activeasc.desiredInclination = Inc;
                    activeasc.enabled = true;
                }
            }
        }

        [KRPCProcedure]
        public static void AscentRdzv()
        {
            MechJebCore activejeb = GetJeb();
            if (activejeb != null)
            {
                MechJebModuleAscentAutopilot activeasc = activejeb.GetComputerModule("MechJebModuleAscentAutopilot") as MechJebModuleAscentAutopilot;
                if (activeasc != null)
                {
                    activeasc.StartCountdown(activeasc.vesselState.time + LaunchTiming.TimeToPhaseAngle(activeasc.launchPhaseAngle, activeasc.vessel.mainBody, activeasc.vessel.longitude,activeasc.core.target.TargetOrbit));   
                    activeasc.enabled = true;
                }
            }
        }

        [KRPCProcedure]
        public static void AscentIntoPlane()
        {
            MechJebCore activejeb = GetJeb();
            if (activejeb != null)
            {
                MechJebModuleAscentAutopilot activeasc = activejeb.GetComputerModule("MechJebModuleAscentAutopilot") as MechJebModuleAscentAutopilot;
                if (activeasc != null)
                {
                    activeasc.StartCountdown(activeasc.vesselState.time + LaunchTiming.TimeToPlane(activeasc.launchLANDifference, activeasc.vessel.mainBody, activeasc.vesselState.latitude, activeasc.vesselState.longitude, activeasc.core.target.TargetOrbit));
                    activeasc.enabled = true;
                }
            }
        }






    }

}
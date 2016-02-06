
using MuMech;
 
using KRPC.Service.Attributes;
 

namespace krpcmj
{

    public static partial class krpcmj
    {
        /// <summary>
        /// Toggles the Ascent AP on and off   
        /// </summary>
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
        /// <summary>
        /// Sets the Altitude for the Ascent AP
        /// </summary>
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
        /// <summary>
        /// Sets the Inclination for the Ascent AP 
        /// </summary>
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
        /// <summary>
        /// Sets the Launch LAN Difference for Launching to Rendezvous
        /// </summary>
        [KRPCProperty]
        public static double AscentLanDifference
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleAscentAutopilot activeasc = activejeb.GetComputerModule("MechJebModuleAscentAutopilot") as MechJebModuleAscentAutopilot;
                    if (activeasc != null)
                    {
                        return activeasc.launchLANDifference;
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
                        activeasc.launchLANDifference = value;
                    }
                }
            }
        }
        /// <summary>
        /// Sets the Launch Phase Angle
        /// </summary>
        [KRPCProperty]
        public static double AscentPhaseAngle
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleAscentAutopilot activeasc = activejeb.GetComputerModule("MechJebModuleAscentAutopilot") as MechJebModuleAscentAutopilot;
                    if (activeasc != null)
                    {
                        return activeasc.launchPhaseAngle;
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
                        activeasc.launchPhaseAngle = value;
                    }
                }
            }
        }
        /// <summary>
        /// Enables Limit to AOA for Ascent AP   
        /// </summary>
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
        /// <summary>
        /// Sets the maximum AOA, used with Limit to AOA
        /// </summary>
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
        /// <summary>
        /// Sets the Roll during the Gravity Turn, used with Force Roll   
        /// </summary>
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
        /// <summary>
        /// Sets the Roll used during vertical ascent, used with Force Roll   
        /// </summary>
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
        /// <summary>
        /// Toggles Force Roll for Ascent AP   
        /// </summary>
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
        /// <summary>
        /// Toggles Force Roll for Ascent AP   
        /// </summary>
        [KRPCProperty]
        public static bool AscentCorrectiveSteering
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleAscentAutopilot activeasc = activejeb.GetComputerModule("MechJebModuleAscentAutopilot") as MechJebModuleAscentAutopilot;
                    if (activeasc != null)
                    {
                        return activeasc.correctiveSteering;
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
                        activeasc.correctiveSteering = value;
                    }
                }
            }
        }

        /// <summary>
        /// Shortcut Method - triggers Immediate Ascent with orbital altitude and inclination as required arguments   
        /// </summary>
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

        /// <summary>
        /// Triggers Ascent to Rendezvous with selected Target Vessel
        /// </summary>
        [KRPCProcedure]
        public static void AscentRdzv(KRPC.SpaceCenter.Services.Vessel Targ)
        {
            MechJebCore activejeb = GetJeb();
            if (activejeb != null)
            {
                MechJebModuleAscentAutopilot activeasc = activejeb.GetComputerModule("MechJebModuleAscentAutopilot") as MechJebModuleAscentAutopilot;
                if (activeasc != null)
                {
                    activeasc.core.target.Set(Targ.InternalVessel);
                    activeasc.core.vessel.targetObject = Targ.InternalVessel;
                    activeasc.StartCountdown(activeasc.vesselState.time + LaunchTiming.TimeToPhaseAngle(activeasc.launchPhaseAngle, activeasc.vessel.mainBody, activeasc.vessel.longitude,activeasc.core.target.TargetOrbit));   
                    activeasc.enabled = true;
                }
            }
        }

        /// <summary>
        /// Triggers Ascent into Plane of selected Target Vessel   
        /// </summary>
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
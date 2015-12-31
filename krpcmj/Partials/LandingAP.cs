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
        public static void LandNow()
        {
            MechJebCore activejeb = GetJeb();
            if (activejeb != null)
            {
                MechJebModuleLandingAutopilot activelnd = activejeb.GetComputerModule("MechJebModuleLandingAutopilot") as MechJebModuleLandingAutopilot;
                if (activelnd != null)
                {
                    activelnd.LandUntargeted(activejeb);
                }
            }
        }
        [KRPCProcedure]
        public static void LandTarget()
        {
            MechJebCore activejeb = GetJeb();
            if (activejeb != null)
            {
                MechJebModuleLandingAutopilot activelnd = activejeb.GetComputerModule("MechJebModuleLandingAutopilot") as MechJebModuleLandingAutopilot;
                if (activelnd != null)
                {
                    activelnd.LandAtPositionTarget(activejeb);
                }
            }
        }
        [KRPCProperty]
        public static bool LandAP
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleLandingAutopilot activelnd = activejeb.GetComputerModule("MechJebModuleLandingAutopilot") as MechJebModuleLandingAutopilot;
                    if (activelnd != null)
                    {
                        return activelnd.enabled;
                    }
                }return false;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleLandingAutopilot activelnd = activejeb.GetComputerModule("MechJebModuleLandingAutopilot") as MechJebModuleLandingAutopilot;
                    if (activelnd != null)
                    {
                        activelnd.enabled = value;
                    }
                }
            }

           
        }
        [KRPCProperty]
        public static bool LandGear
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleLandingAutopilot activelnd = activejeb.GetComputerModule("MechJebModuleLandingAutopilot") as MechJebModuleLandingAutopilot;
                    if (activelnd != null)
                    {
                        return activelnd.deployGears;
                    }
                }
                return false;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleLandingAutopilot activelnd = activejeb.GetComputerModule("MechJebModuleLandingAutopilot") as MechJebModuleLandingAutopilot;
                    if (activelnd != null)
                    {
                        activelnd.deployGears = value;
                    }
                }
            }


        }
        [KRPCProperty]
        public static bool LandChutes
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleLandingAutopilot activelnd = activejeb.GetComputerModule("MechJebModuleLandingAutopilot") as MechJebModuleLandingAutopilot;
                    if (activelnd != null)
                    {
                        return activelnd.deployChutes;
                    }
                }
                return false;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleLandingAutopilot activelnd = activejeb.GetComputerModule("MechJebModuleLandingAutopilot") as MechJebModuleLandingAutopilot;
                    if (activelnd != null)
                    {
                        activelnd.deployChutes = value;
                    }
                }
            }


        }
        [KRPCProperty]
        public static double LandUT
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleLandingAutopilot activelnd = activejeb.GetComputerModule("MechJebModuleLandingAutopilot") as MechJebModuleLandingAutopilot;
                    if (activelnd != null)
                    {
                        return activelnd.prediction.endUT;
                    }
                }
                return 0.0;
            }
        }
        [KRPCProcedure]
        public static void LandPickTarget()
        {
            MechJebCore activejeb = GetJeb();
            if (activejeb != null)
            {
                activejeb.target.PickPositionTargetOnMap();
            }
        }
        [KRPCProcedure]
        public static void LandSetTarget(double lat, double lon)
        {
            MechJebCore activejeb = GetJeb();
            if (activejeb != null)
            {
                activejeb.target.SetPositionTarget(activejeb.vessel.mainBody, lat, lon);
            }
        }
        [KRPCProperty]
        public static double LandTargetLat
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    if (activejeb.target.PositionTargetExists)
                    {
                        return activejeb.target.targetLatitude;
                    }
                }
                return 0.0;
            }
        }
        [KRPCProperty]
        public static double LandTargetLong
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    if (activejeb.target.PositionTargetExists)
                    {
                        return activejeb.target.targetLongitude;
                    }
                }
                return 0.0;
            }
        }

    }

}
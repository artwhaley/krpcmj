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
        public static bool DockingAp
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleDockingAutopilot activedock = activejeb.GetComputerModule("MechJebModuleDockingAutopilot") as MechJebModuleDockingAutopilot;
                    if (activedock != null)
                    {
                        return activedock.enabled;
                    }
                }return false;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleDockingAutopilot activedock = activejeb.GetComputerModule("MechJebModuleDockingAutopilot") as MechJebModuleDockingAutopilot;
                    if (activedock != null)
                    {
                        activedock.enabled = value;
                    }
                }
            }
        }

        [KRPCProperty]
        public static bool DockingOverideDistance
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleDockingAutopilot activedock = activejeb.GetComputerModule("MechJebModuleDockingAutopilot") as MechJebModuleDockingAutopilot;
                    if (activedock != null)
                    {
                        return activedock.overrideSafeDistance;
                    }
                }
                return false;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleDockingAutopilot activedock = activejeb.GetComputerModule("MechJebModuleDockingAutopilot") as MechJebModuleDockingAutopilot;
                    if (activedock != null)
                    {
                        activedock.overrideSafeDistance = value;
                    }
                }
            }
        }

        [KRPCProperty]
        public static bool DockingForceRoll
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleDockingAutopilot activedock = activejeb.GetComputerModule("MechJebModuleDockingAutopilot") as MechJebModuleDockingAutopilot;
                    if (activedock != null)
                    {
                        return activedock.forceRol;
                    }
                }
                return false;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleDockingAutopilot activedock = activejeb.GetComputerModule("MechJebModuleDockingAutopilot") as MechJebModuleDockingAutopilot;
                    if (activedock != null)
                    {
                        activedock.forceRol = value;
                    }
                }
            }
        }

        [KRPCProperty]
        public static double DockingForceRollAngle
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleDockingAutopilot activedock = activejeb.GetComputerModule("MechJebModuleDockingAutopilot") as MechJebModuleDockingAutopilot;
                    if (activedock != null)
                    {
                        return activedock.rol;
                    }
                }
                return 0.0;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleDockingAutopilot activedock = activejeb.GetComputerModule("MechJebModuleDockingAutopilot") as MechJebModuleDockingAutopilot;
                    if (activedock != null)
                    {
                        activedock.rol = value;
                    }
                }
            }
        }

        [KRPCProperty]
        public static double DockingSpeedLimit
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleDockingAutopilot activedock = activejeb.GetComputerModule("MechJebModuleDockingAutopilot") as MechJebModuleDockingAutopilot;
                    if (activedock != null)
                    {
                        return activedock.speedLimit;
                    }
                }
                return 0.0;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleDockingAutopilot activedock = activejeb.GetComputerModule("MechJebModuleDockingAutopilot") as MechJebModuleDockingAutopilot;
                    if (activedock != null)
                    {
                        activedock.speedLimit = value;
                    }
                }
            }
        }

    }
}
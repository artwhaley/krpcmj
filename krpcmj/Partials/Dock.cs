
using MuMech;
using KRPC.Service.Attributes;


namespace krpcmj
{

    public static partial class krpcmj
    {

        /// <summary>
        /// Engages and Disengages Docking Autopilot
        /// </summary>
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

        /// <summary>
        ///Toggles Docking Safe Distance Override
        /// </summary>
        [KRPCProperty]
        public static bool DockingOverideSafeDistance
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
      
        /// <summary>
        /// Toggles Docking Force Roll   
        /// </summary>
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

        /// <summary>
        /// Sets Docking Angle to use with Force Roll  
        /// </summary>
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

        /// <summary>
        /// Sets Docking Speed Limit   
        /// </summary>
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

        /// <summary>
        /// Gets Docking X Seperation   
        /// </summary>
        [KRPCProperty]
        public static double DockingSepX
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleDockingAutopilot activedock = activejeb.GetComputerModule("MechJebModuleDockingAutopilot") as MechJebModuleDockingAutopilot;
                    if (activedock != null)
                    {
                        return activedock.lateralSep.x;
                    }
                }
                return 0.0;
            }
          
        }

        /// <summary>
        /// Gets Docking Y Seperation  
        /// </summary>
        [KRPCProperty]
        public static double DockingSepY
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleDockingAutopilot activedock = activejeb.GetComputerModule("MechJebModuleDockingAutopilot") as MechJebModuleDockingAutopilot;
                    if (activedock != null)
                    {
                        return activedock.lateralSep.y;
                    }
                }
                return 0.0;
            }
          
        }

        /// <summary>
        /// Gets DockingZ Separation   
        /// </summary>
        [KRPCProperty]
        public static double DockingSepZ
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleDockingAutopilot activedock = activejeb.GetComputerModule("MechJebModuleDockingAutopilot") as MechJebModuleDockingAutopilot;
                    if (activedock != null)
                    {
                        return activedock.zSep;
                    }
                }
                return 0.0;
            }
          
        }


    }
}

using MuMech;
using KRPC.Service.Attributes;


namespace krpcmj
{

    public static partial class krpcmj
    {
        /// <summary>
        /// Toggles Rendezvous AP on and off
        /// </summary>
        [KRPCProperty]
        public static bool RendezvousAP
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleRendezvousAutopilot activerend = activejeb.GetComputerModule("MechJebModuleRendezvousAutopilot") as MechJebModuleRendezvousAutopilot;
                    if (activerend != null)
                    {
                        return activerend.enabled;
                    }
                }
                return false;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleRendezvousAutopilot activerend = activejeb.GetComputerModule("MechJebModuleRendezvousAutopilot") as MechJebModuleRendezvousAutopilot;
                    if (activerend != null)
                    {
                        if(value==true) activerend.enabled = true;
                        else activerend.enabled=false;
                    }
                }
            }
        }

        /// <summary>
        /// Target distance for Rendezvous AP
        /// </summary>
        [KRPCProperty]
        public static double rdzvDist
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleRendezvousAutopilot activerend = activejeb.GetComputerModule("MechJebModuleRendezvousAutopilot") as MechJebModuleRendezvousAutopilot;
                    if (activerend != null)
                    {
                        return activerend.desiredDistance;
                    }

                }
                return 0.0;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleRendezvousAutopilot activerend = activejeb.GetComputerModule("MechJebModuleRendezvousAutopilot") as MechJebModuleRendezvousAutopilot;
                    if (activerend != null)
                    {
                        activerend.desiredDistance = value;
                    }
                }
            }
        }

        /// <summary>
        /// Sets Max number of orbits for the Rendezvous AP 
        /// </summary>
        [KRPCProperty]
        public static double rdzvMaxOrbits
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleRendezvousAutopilot activerend = activejeb.GetComputerModule("MechJebModuleRendezvousAutopilot") as MechJebModuleRendezvousAutopilot;
                    if (activerend != null)
                    {
                        return activerend.maxPhasingOrbits;
                    }

                }
                return 0.0;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleRendezvousAutopilot activerend = activejeb.GetComputerModule("MechJebModuleRendezvousAutopilot") as MechJebModuleRendezvousAutopilot;
                    if (activerend != null)
                    {
                        activerend.maxPhasingOrbits = value;
                    }
                }
            }
        }

    }

}
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
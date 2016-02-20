
using MuMech;
using KRPC.Service.Attributes;

namespace krpcmj
{
    public static partial class krpcmj
    {
        /// <summary>
        /// Warp To Apoapsis
        /// </summary>
        [KRPCProcedure]
        public static void WarptoApa()
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
    }
}


using MuMech;
using KRPC.Service.Attributes;

namespace krpcmj
{
    public static partial class krpcmj
    {
        [KRPCEnum]
        public enum TransMode
        {
            OFF,ORBITAL,SURFACE,VERTICAL,RELATIVE,DIRECT
        }

        /// <summary>
        /// Translatron Mode Enabled/Disabled
        /// </summary>
        [KRPCProperty]
        public static bool TranslatronAP
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleTranslatron activetrans = activejeb.GetComputerModule("MechJebModuleTranslatron") as MechJebModuleTranslatron;
                    if (activetrans != null)
                    {
                        return activetrans.enabled;
                    }
                }
                return false;
            }

            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleTranslatron activetrans = activejeb.GetComputerModule("MechJebModuleTranslatron") as MechJebModuleTranslatron;
                    if (activetrans != null)
                    {
                        activetrans.enabled = value;
                    }
                }
            }
        }

        /// <summary>
        /// Translatorn Cancel Horizontal Velocity
        /// </summary>
        [KRPCProperty]
        public static bool TranslatronCancelHv
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleTranslatron activetrans = activejeb.GetComputerModule("MechJebModuleTranslatron") as MechJebModuleTranslatron;
                    if (activetrans != null)
                    {
                        return activetrans.core.thrust.trans_kill_h;
                    }
                }
                return false;
            }

            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleTranslatron activetrans = activejeb.GetComputerModule("MechJebModuleTranslatron") as MechJebModuleTranslatron;
                    if (activetrans != null)
                    {
                        activetrans.core.thrust.trans_kill_h = value;
                    }
                }
            }
        }

        /// <summary>
        /// Translatron Vertical Velocity Target
        /// </summary>
        [KRPCProperty]
        public static double TranslatronVv
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleTranslatron activetrans = activejeb.GetComputerModule("MechJebModuleTranslatron") as MechJebModuleTranslatron;
                    if (activetrans != null)
                    {
                        return activetrans.core.thrust.trans_spd_act;
                    }
                }
                return 0.0;
            }

            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleTranslatron activetrans = activejeb.GetComputerModule("MechJebModuleTranslatron") as MechJebModuleTranslatron;
                    if (activetrans != null)
                    {
                        activetrans.core.thrust.trans_spd_act = (float)value;
                    }
                }
            }
        }

        /// <summary>
        /// Translatron Mode
        /// </summary>
        [KRPCProperty]
        public static TransMode TranslatronMode
        {
         //   get
         //   {
         //       MechJebCore activejeb = GetJeb();
         //       if (activejeb != null)
         //       {
         //           MechJebModuleTranslatron activetrans = activejeb.GetComputerModule("MechJebModuleTranslatron") as MechJebModuleTranslatron;
         //           if (activetrans != null)
         //           {
         //               return activetrans.enabled;
         //           }
         //       }
         //       return 0.0;
         //   }

            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleTranslatron activetrans = activejeb.GetComputerModule("MechJebModuleTranslatron") as MechJebModuleTranslatron;
                    if (activetrans != null)
                    {
                        activetrans.SetMode((MechJebModuleThrustController.TMode)value);
                    }
                }
            }
        }


        public static void TranslatronCancel()
        {
            MechJebCore activejeb = GetJeb();
            if (activejeb != null)
            {
                MechJebModuleTranslatron activetrans = activejeb.GetComputerModule("MechJebModuleTranslatron") as MechJebModuleTranslatron;
                if (activetrans != null)
                {

                    activetrans.SetMode(MechJebModuleThrustController.TMode.OFF);


                }
            }
        }
    }
}
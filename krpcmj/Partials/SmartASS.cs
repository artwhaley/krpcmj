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
        [KRPCEnum]
        public enum SAMode
        {
            OFF,
            KILLROT,
            NODE,
            SURFACE,
            PROGRADE,
            RETROGRADE,
            NORMAL_PLUS,
            NORMAL_MINUS,
            RADIAL_PLUS,
            RADIAL_MINUS,
            RELATIVE_PLUS,
            RELATIVE_MINUS,
            TARGET_PLUS,
            TARGET_MINUS,
            PARALLEL_PLUS,
            PARALLEL_MINUS,
            ADVANCED,
            AUTO,
            SURFACE_PROGRADE,
            SURFACE_RETROGRADE,
            HORIZONTAL_PLUS,
            HORIZONTAL_MINUS,
            VERTICAL_PLUS
        }



        /// <summary>
        /// The smartASS mode   
        /// </summary>
        [KRPCProperty]
        public static SAMode saMode
        {
            set
            {
                MechJebCore activemech = GetJeb();
                 if (activemech != null)
                 {
                     MechJebModuleSmartASS activeass = activemech.GetComputerModule("MechJebModuleSmartASS") as MechJebModuleSmartASS;
                      if (activeass != null){
                          activeass.target = (MechJebModuleSmartASS.Target)value;
                          if(activeass.target==MechJebModuleSmartASS.Target.PROGRADE|| activeass.target == MechJebModuleSmartASS.Target.RETROGRADE || activeass.target == MechJebModuleSmartASS.Target.NORMAL_PLUS || activeass.target == MechJebModuleSmartASS.Target.NORMAL_MINUS || activeass.target == MechJebModuleSmartASS.Target.RADIAL_PLUS || activeass.target == MechJebModuleSmartASS.Target.RADIAL_MINUS) { activeass.mode = MechJebModuleSmartASS.Mode.ORBITAL; }
                          if(activeass.target == MechJebModuleSmartASS.Target.SURFACE_PROGRADE || activeass.target == MechJebModuleSmartASS.Target.SURFACE_RETROGRADE || activeass.target == MechJebModuleSmartASS.Target.HORIZONTAL_PLUS || activeass.target == MechJebModuleSmartASS.Target.HORIZONTAL_MINUS || activeass.target == MechJebModuleSmartASS.Target.SURFACE || activeass.target == MechJebModuleSmartASS.Target.VERTICAL_PLUS) { activeass.mode = MechJebModuleSmartASS.Mode.SURFACE; }
                          if(activeass.target == MechJebModuleSmartASS.Target.TARGET_PLUS || activeass.target == MechJebModuleSmartASS.Target.TARGET_MINUS || activeass.target == MechJebModuleSmartASS.Target.RELATIVE_PLUS || activeass.target == MechJebModuleSmartASS.Target.RELATIVE_MINUS || activeass.target == MechJebModuleSmartASS.Target.PARALLEL_PLUS || activeass.target == MechJebModuleSmartASS.Target.PARALLEL_MINUS) { activeass.mode = MechJebModuleSmartASS.Mode.TARGET; }
                      }
                   }
            }
            get
            {
                MechJebCore activemech = krpcmj.GetJeb();
                if (activemech != null)
                {
                    MechJebModuleSmartASS activeass = activemech.GetComputerModule("MechJebModuleSmartASS") as MechJebModuleSmartASS;
                    if (activeass != null)
                    { return (SAMode)activeass.target; }
                    else { return 0; }
                }
                else { return 0; }
            }
        }

        /// <summary>
        /// Toggles smartASS off 
        /// </summary>
        [KRPCProperty]
        public static bool saStatus
        {
            get
            {
                MechJebCore activemech = krpcmj.GetJeb();
                if (activemech != null)
                {
                    MechJebModuleSmartASS activeass = activemech.GetComputerModule("MechJebModuleSmartASS") as MechJebModuleSmartASS;
                    if (activeass != null)
                    {
                        if (activeass.target == 0) { return true; }
                        else { return false; }
                    }
                    else { return false; }
                }
                else { return false; }
            }
            set
            {
                MechJebCore activemech = krpcmj.GetJeb();
                if (activemech != null)
                {
                    MechJebModuleSmartASS activeass = activemech.GetComputerModule("MechJebModuleSmartASS") as MechJebModuleSmartASS;
                    if (activeass != null)
                    {
                        if (value == true)
                        {
                            activeass.Engage();
                            if (activeass.target == MechJebModuleSmartASS.Target.PROGRADE || activeass.target == MechJebModuleSmartASS.Target.RETROGRADE || activeass.target == MechJebModuleSmartASS.Target.NORMAL_PLUS || activeass.target == MechJebModuleSmartASS.Target.NORMAL_MINUS || activeass.target == MechJebModuleSmartASS.Target.RADIAL_PLUS || activeass.target == MechJebModuleSmartASS.Target.RADIAL_MINUS) { activeass.mode = MechJebModuleSmartASS.Mode.ORBITAL; }
                            if (activeass.target == MechJebModuleSmartASS.Target.SURFACE_PROGRADE || activeass.target == MechJebModuleSmartASS.Target.SURFACE_RETROGRADE || activeass.target == MechJebModuleSmartASS.Target.HORIZONTAL_PLUS || activeass.target == MechJebModuleSmartASS.Target.HORIZONTAL_MINUS || activeass.target == MechJebModuleSmartASS.Target.SURFACE || activeass.target == MechJebModuleSmartASS.Target.VERTICAL_PLUS) { activeass.mode = MechJebModuleSmartASS.Mode.SURFACE; }
                            if (activeass.target == MechJebModuleSmartASS.Target.TARGET_PLUS || activeass.target == MechJebModuleSmartASS.Target.TARGET_MINUS || activeass.target == MechJebModuleSmartASS.Target.RELATIVE_PLUS || activeass.target == MechJebModuleSmartASS.Target.RELATIVE_MINUS || activeass.target == MechJebModuleSmartASS.Target.PARALLEL_PLUS || activeass.target == MechJebModuleSmartASS.Target.PARALLEL_MINUS) { activeass.mode = MechJebModuleSmartASS.Mode.TARGET; }
                        }
                        else { activeass.target = 0; }
                    }

                }
            }
        }

        
        /// <summary>
        /// Activates smartASS and Sets Heading, Pitch and Roll for Surface Reference mode
        /// </summary>
        [KRPCProcedure]
        public static void saSurface(float hdg, float pit, float rol)
        {
            MechJebCore activejeb =krpcmj.GetJeb();
            if (activejeb != null)
            {
                MechJebModuleSmartASS activeass = activejeb.GetComputerModule("MechJebModuleSmartASS") as MechJebModuleSmartASS;
                if (activeass != null)
                {
                    activeass.mode = MechJebModuleSmartASS.Mode.SURFACE;
                    activeass.srfHdg = hdg;
                    activeass.srfPit = pit;
                    activeass.srfRol = rol;
                    activeass.target = MechJebModuleSmartASS.Target.SURFACE;
                    activeass.Engage();
                }
            }
        }
        /// <summary>
        /// Enabling force roll and accepting a float for roll value
        /// </summary>
        [KRPCProcedure]
        public static void saForceroll(float rol)
        {
            MechJebCore activejeb =krpcmj.GetJeb();
            if (activejeb != null)
            {
                MechJebModuleSmartASS activeass = activejeb.GetComputerModule("MechJebModuleSmartASS") as MechJebModuleSmartASS;
                if (activeass != null)
                {
                    activeass.rol = rol;
                    activeass.forceRol = true;
                }
            }
        }
        /// <summary>
        /// Disables Force Roll
        /// </summary>
        [KRPCProcedure]
        public static void saForcerollClear()
        {
            MechJebCore activejeb =krpcmj.GetJeb();
            if (activejeb != null)
            {
                MechJebModuleSmartASS activeass = activejeb.GetComputerModule("MechJebModuleSmartASS") as MechJebModuleSmartASS;
                if (activeass != null)
                {

                    activeass.forceRol = false;
                   
                }
            }
        }

    }
}

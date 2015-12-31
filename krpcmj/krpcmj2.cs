using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KRPC.Service;
using KRPC.Service.Attributes;
using MuMech;
using UnityEngine;
using KRPC.Utils;


namespace krpcmj
{
    /// <summary>
    /// Service for interfacing with mechjeb units 
    /// </summary>
    [KRPCClass(Service = "krpcmj")]
    public sealed class mj :  Equatable<mj>
    {
        readonly Part part;
        readonly MechJebCore core;
        

        internal mj(Part part)
        {
            this.part = part;
            foreach (PartModule thatmodule in part.Modules)
                {
                    if (thatmodule is MechJebCore)
                    {
                        var thatmechjeb = thatmodule as MechJebCore;
                       this.core = thatmechjeb.MasterMechJeb;
                    }
                }
            

        }

        public override bool Equals(mj j)
        {
            return part == j.part;
        }

        public override int GetHashCode()
        {
            return part.GetHashCode();
        }

        /// <summary>
        /// Activates smartASS, pointing orbital prograde
        /// </summary>
        [KRPCProcedure]
        public void saPrograde()
        {
                MechJebModuleSmartASS activeass = core.GetComputerModule("MechJebModuleSmartASS") as MechJebModuleSmartASS;
                if (activeass != null)
                {
                    activeass.mode = MechJebModuleSmartASS.Mode.ORBITAL;
                    activeass.target = MechJebModuleSmartASS.Target.PROGRADE;
                    activeass.Engage();
                }
            }
        }


    }



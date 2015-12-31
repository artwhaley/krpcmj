using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KRPC.Service;
using KRPC.Service.Attributes;
using MuMech;
using UnityEngine;

namespace KRPCSpaceCenter.Services
{
    public static class krpcmjExtensions
    {
        /// <summary>
        /// Gets the Active Mechjeb on a named vessel
        /// </summary>
        [KRPCProcedure]
        public static Part GetJeb(this Vessel v)
        {
            
            Part activemech = null;
            List<Part> p = v.parts;
            foreach (Part thatpart in p)
            {
                foreach (PartModule thatmodule in thatpart.Modules)
                {
                    if (thatmodule is MechJebCore)
                    {
                        var thatmechjeb = thatmodule as MechJebCore;
                        activemech = thatmechjeb.MasterMechJeb.part;
                    }
                }
            }
            return activemech;
        }

    }
}

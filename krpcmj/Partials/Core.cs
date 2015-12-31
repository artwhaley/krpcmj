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
        public static bool CoreLimitThrottle
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                   return activejeb.thrust.limitThrottle;
                }
                return false;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    activejeb.thrust.limitThrottle = value;
                }
            }
        }

        [KRPCProperty]
        public static double CoreMaxThrottle
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    return activejeb.thrust.maxThrottle;
                }
                return 0.0;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                   
                    activejeb.thrust.maxThrottle.val = value;
                    
                }
            }
        }

        [KRPCProperty]
        public static bool CoreLimitTerminalV
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    return activejeb.thrust.limitToTerminalVelocity;
                }
                return false;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    activejeb.thrust.limitToTerminalVelocity = value;
                }
            }
        }

        [KRPCProperty]
        public static bool CoreLimitQ
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    return activejeb.thrust.limitDynamicPressure;
                }
                return false;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    activejeb.thrust.limitDynamicPressure = value;
                }
            }
        }

        [KRPCProperty]
        public static double CoreMaxQ
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    return activejeb.thrust.maxDynamicPressure;
                }
                return 0.0;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                   
                        activejeb.thrust.maxDynamicPressure = value;
                    
                }
            }
        }

        [KRPCProperty]
        public static bool CoreLimitAccel
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    return activejeb.thrust.limitAcceleration;
                }
                return false;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    activejeb.thrust.limitAcceleration = value;
                }
            }
        }

        [KRPCProperty]
        public static double CoreMaxAccel
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    return activejeb.thrust.maxAcceleration;
                }
                return 0.0;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {

                    activejeb.thrust.maxAcceleration = value;

                }
            }
        }


    }
}
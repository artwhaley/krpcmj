
using MuMech;
using KRPC.Service.Attributes;

namespace krpcmj
{
    public static partial class krpcmj
    {

        /// <summary>
        /// Toggles throttle limiting  
        /// </summary>
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

        /// <summary>
        /// Sets max throttle for throttle limiting   
        /// </summary>
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

        /// <summary>
        /// Toggles limiting to Terminal Velocity   
        /// </summary>
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

        /// <summary>
        /// Toggles limiting to Max Q   
        /// </summary>
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

        /// <summary>
        /// Sets Max Q for limiter   
        /// </summary>
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

        /// <summary>
        /// Toggles limiting acceleration   
        /// </summary>
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

        /// <summary>
        /// Sets Max Acceleration for limiter   
        /// </summary>
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

        /// <summary>
        /// Toggles AutoWarp for Mechjeb
        /// </summary>
        [KRPCProperty]
        public static bool Autowarp
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    return activejeb.node.autowarp;
                }
                return false;
            }
            set
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    activejeb.node.autowarp = value;
                }
            }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KRPC.Service;
using KRPC.Service.Attributes;
using MuMech;
using UnityEngine;
using KRPCSpaceCenter;

namespace krpcmj
{
    [KRPCService(GameScene = GameScene.Flight)]
    public static partial class krpcmj
    {
        public static Vessel mjvessel;

        [KRPCProperty]
        public static KRPCSpaceCenter.Services.Vessel apvessel
        {
            set { mjvessel = value.InternalVessel; }
            get {
                foreach(KRPCSpaceCenter.Services.Vessel v in KRPCSpaceCenter.Services.SpaceCenter.Vessels)
                {
                    if (v.InternalVessel == mjvessel) { return v; }
                    
                }
                return null;

            }
           
        }

        [KRPCProperty]
        public static int apStatus
        {
            get
            {
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleAscentAutopilot activeasc = activejeb.GetComputerModule("MechJebModuleAscentAutopilot") as MechJebModuleAscentAutopilot;
                    MechJebModuleDockingAutopilot activedock = activejeb.GetComputerModule("MechJebModuleDockingAutopilot") as MechJebModuleDockingAutopilot;
                    MechJebModuleLandingAutopilot activeland = activejeb.GetComputerModule("MechJebModuleLandingAutopilot") as MechJebModuleLandingAutopilot;
                    MechJebModuleNodeExecutor activenoder = activejeb.GetComputerModule("MechJebModuleNodeExecutor") as MechJebModuleNodeExecutor;
                    MechJebModuleRendezvousAutopilot activerendez = activejeb.GetComputerModule("MechJebModuleRendezvousAutopilot") as MechJebModuleRendezvousAutopilot;
                    MechJebModuleSmartASS activeass = activejeb.GetComputerModule("MechJebModuleSmartASS") as MechJebModuleSmartASS;
                    MechJebModuleTranslatron activetrans = activejeb.GetComputerModule("MechJebModuleTranslatron") as MechJebModuleTranslatron;

                    int holder = 0;
                    if (activeasc.enabled == true) { holder += 1; } //1 for ascent module
                    if (activedock.enabled == true) { holder += 2; } //2 for docking module
                    if (activeland.enabled == true) { holder += 4; } //4 for landing module
                    if (activenoder.enabled == true) { holder += 8; } //8 for node executor module
                    if (activerendez.enabled == true) { holder += 16; } //16 rendezvous module
                    if (activetrans.enabled == true) { holder += 64; }//64 for translate
                    return holder;
                }
                return (byte)0;
            }
        }

        public static MechJebCore GetJeb()
        {
            MechJebCore activemech = null;
            //      List<Part> p = mjvessel.parts;
            List<Part> p = mjvessel.parts;// FlightGlobals.ActiveVessel.parts;

            foreach (Part thatpart in p)
            {
                foreach (PartModule thatmodule in thatpart.Modules)
                {
                    if (thatmodule is MechJebCore)
                    {
                        var thatmechjeb = thatmodule as MechJebCore;
                        activemech = thatmechjeb.MasterMechJeb;
                    }
                }
            }
            return activemech;
        }

    }
}
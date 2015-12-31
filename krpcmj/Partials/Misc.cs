﻿using System;
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
        public static string dvstats
        {
            get
            {
                string B = "";
                MechJebCore activejeb = GetJeb();
                if (activejeb != null)
                {
                    MechJebModuleStageStats activestats = activejeb.GetComputerModule("MechJebModuleStageStats") as MechJebModuleStageStats;
                    if (activestats != null)
                    {

                        activestats.RequestUpdate(activejeb);
                        int len = activestats.atmoStats.Length;
                        for (int i = 0; i < len; i++)
                        {
                            B += i.ToString();
                            B += ",";
                            B += activestats.atmoStats[i].deltaV.ToString();
                            B += ",";
                            B += activestats.atmoStats[i].StartTWR(1).ToString();
                            B += ",";
                            B += activestats.vacStats[i].deltaV.ToString();
                            B += ",";
                            B += activestats.vacStats[i].StartTWR(1).ToString();
                            B += ",";
                            B += activestats.vacStats[i].deltaTime.ToString();
                            B += ";";




                        }




                    }
                }
                return B;
            }

        }


        [KRPCProcedure]
        public static void RoverHeading(float head, float speed)
        {
            MechJebCore activejeb = GetJeb();
            if (activejeb != null)
            {
                MechJebModuleRoverController activerover = activejeb.GetComputerModule("MechJebModuleRoverController") as MechJebModuleRoverController;
                if (activerover != null)
                {
                    activerover.heading = head;
                    activerover.ControlHeading = true;
                    activerover.tgtSpeed = speed;
                    activerover.ControlSpeed = true;
                    activerover.enabled = true;


                }
            }
        }
        [KRPCProcedure]
        public static void Translatron(float vv, bool hv)
        {
            MechJebCore activejeb = GetJeb();
            if (activejeb != null)
            {
                MechJebModuleTranslatron activetrans = activejeb.GetComputerModule("MechJebModuleTranslatron") as MechJebModuleTranslatron;
                if (activetrans != null)
                {
                    activetrans.core.thrust.trans_spd_act = vv;
                    activetrans.core.thrust.trans_kill_h = hv;
                    activetrans.SetMode(MechJebModuleThrustController.TMode.KEEP_VERTICAL);


                }
            }
        }
        [KRPCProcedure]
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
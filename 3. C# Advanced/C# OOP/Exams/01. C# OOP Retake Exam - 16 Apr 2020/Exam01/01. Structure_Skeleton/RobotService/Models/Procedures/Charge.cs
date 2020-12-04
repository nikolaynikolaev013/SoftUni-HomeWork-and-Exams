﻿using System;
using RobotService.Models.Robots.Contracts;

namespace RobotService.Models.Procedures
{
    public class Charge : Procedure
    {
        public override void DoService(IRobot robot, int procedureTime)
        {
            base.DoService(robot, procedureTime);

            robot.ProcedureTime -= procedureTime;
            this.Robots.Add(robot);
            robot.Happiness += 12;
            robot.Energy += 10;
        }
    }
}
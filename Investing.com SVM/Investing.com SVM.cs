using System;
using System.Linq;
using cAlgo.API;
using cAlgo.API.Indicators;
using cAlgo.API.Internals;
using cAlgo.Indicators;

namespace cAlgo.Robots
{
    [Robot(TimeZone = TimeZones.UTC, AccessRights = AccessRights.None)]
    public class NewcBot : Robot
    {
        [Parameter("Robot ID", DefaultValue = "Investing.com Indicators")]
        public string RobotID { get; set; }

        public enum TradingModes
        {
            Polling,
            SVM
        }

        [Parameter("Trading Mode", DefaultValue = TradingModes.Polling, Group = "Trading Mode")]
        public TradingModes TradingMode { get; set; }

        [Parameter("Trading Hours in UTC", DefaultValue = "8:00-16:00", Group = "Trading Mode")]
        public string TradingHours { get; set; }

        // Moving averages.
        //[Parameter("MA5 Simple", DefaultValue = true, Group = "Moving Averages")]

        protected override void OnStart()
        {
            // Put your initialization logic here
        }

        protected override void OnTick()
        {
            // Put your core logic here
        }

        protected override void OnStop()
        {
            // Put your deinitialization logic here
        }
    }
}

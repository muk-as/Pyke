﻿using Pyke;
using Pyke.ChampSelect.Models;
using Pyke.Events;
using Pyke.Events.Models;
using Pyke.Websocket;
using System;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using static Pyke.Events.ILeagueEvents;
using static Pyke.Window.WindowHandler;

namespace Pyke.Example
{
    class Program
    {
        private static PykeAPI API;
        static void Main(string[] args)
        {
            API = new PykeAPI(Serilog.Events.LogEventLevel.Information).ConnectAsync().GetAwaiter().GetResult();

            API.Events.SubscribeAllEvents();
            API.Events.GameflowStateChanged += (s, e) => {
                Console.WriteLine(e.ToString());
            };

            while (true)
            {
                var url = Console.ReadLine();
            }
        }
    }
}

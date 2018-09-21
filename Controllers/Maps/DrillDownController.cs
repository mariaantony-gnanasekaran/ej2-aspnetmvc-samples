﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Maps;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using Newtonsoft.Json.Linq;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Maps
{
    public partial class MapsController : Controller
    {
        // GET: DrillDown
        public ActionResult DrillDown()
        {
            ViewBag.World = this.getWorldMap();
            ViewBag.Africa = this.getAfricaMap();
            ViewBag.Asia = this.getAsiaMap();
            ViewBag.Eurpoe = this.getEuropeMap();
            ViewBag.NorthAmerica = this.getNorthAmericaMap();
            ViewBag.SouthAmerica = this.getSouthAmericaMap();
            ViewBag.Oceania = this.getOceaniaMap();
             ViewBag.DataSource = this.getDrillData();
            return View();
        }

        public object getDrillData()
        {
            JObject data = JObject.Parse(System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MapData/DrillData.json")));
            return data["DrillDown"];
        }

        public object getAfricaMap()
        {
            JObject world = JObject.Parse(System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MapData/Africa.json")));
            return world;
        }

        public object getAsiaMap()
        {
            JObject world = JObject.Parse(System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MapData/Asia.json")));
            return world;
        }

        public object getEuropeMap()
        {
            JObject world = JObject.Parse(System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MapData/Europe.json")));
            return world;
        }

        public object getNorthAmericaMap()
        {
            JObject world = JObject.Parse(System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MapData/NorthAmerica.json")));
            return world;
        }

        public object getSouthAmericaMap()
        {
            JObject world = JObject.Parse(System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MapData/SouthAmerica.json")));
            return world;
        }

        public object getOceaniaMap()
        {
            JObject world = JObject.Parse(System.IO.File.ReadAllText(Server.MapPath("~/App_Data/MapData/Oceania.json")));
            return world;
        }

    }
}
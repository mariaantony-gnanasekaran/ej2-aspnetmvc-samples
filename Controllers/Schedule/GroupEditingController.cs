﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syncfusion.EJ2.Schedule;
using EJ2MVCSampleBrowser.Models;

namespace EJ2MVCSampleBrowser.Controllers.Schedule
{
    public partial class ScheduleController : Controller
    {
        public ActionResult GroupEditing()
        {
            ViewBag.datasource = new ScheduleData().GetResourceConferenceData();
            var monthEventTemplate = "<div class='subject'>${Subject}</div>";
            List<ScheduleView> viewOption = new List<ScheduleView>()
            {
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Day },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Week },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.WorkWeek },
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.Month, EventTemplate = monthEventTemplate},
                new ScheduleView {Option = Syncfusion.EJ2.Schedule.View.TimelineWeek }
            };
            ViewBag.view = viewOption;

            List<ResourceDataSourceModel> conferences = new List<ResourceDataSourceModel>();
            conferences.Add(new ResourceDataSourceModel { text = "Margaret", id = 1, color = "#1aaa55" });
            conferences.Add(new ResourceDataSourceModel { text = "Robert", id = 2, color = "#357cd2" });
            conferences.Add(new ResourceDataSourceModel { text = "Laura", id = 3, color = "#7fa900" });
            ViewBag.Conferences = conferences;

            string[] resources = new string[] { "Conferences" };
            ViewBag.Resources = resources;
            return View();
        }
    }
}
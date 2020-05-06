using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContactManager.Models.LSP;
using Microsoft.AspNetCore.Mvc;

namespace ContactManager.Controllers
{
    public class SettingsController : Controller
    {
        // List<ISettings> settings = new List<ISettings>();
        List<IReadableSettings> readableSettings = new List<IReadableSettings>();
        List<IWritableSettings> writableSettings = new List<IWritableSettings>();

        public SettingsController()
        {
            GlobalSettings g = new GlobalSettings();
            SectionSettings s = new SectionSettings();
            UserSettings u = new UserSettings();
            GuestSettings gu = new GuestSettings();

            //settings.Add(g);
            //settings.Add(s);
            //settings.Add(u);
            //settings.Add(gu);

            readableSettings.Add(g);
            readableSettings.Add(s);
            readableSettings.Add(u);
            readableSettings.Add(gu);

            writableSettings.Add(g);
            writableSettings.Add(s);
            writableSettings.Add(u);
        }
        
        public IActionResult Index()
        {
            // var allSettings = SettingsHelper.GetAllSettings(settings);
            var allSettings = SettingsHelper.GetAllSettings(readableSettings);
            return View(allSettings);
        }

        public IActionResult Save()
        {
            List<Dictionary<string, string>> newSettings = new List<Dictionary<string, string>>();
            
            Dictionary<string, string> app = new Dictionary<string, string>();
            app.Add("Theme", "Winter");
            
            Dictionary<string, string> sec = new Dictionary<string, string>();
            sec.Add("Title", "Music");
            
            Dictionary<string, string> usr = new Dictionary<string, string>();
            usr.Add("DisplayName", "Tom");
            
            Dictionary<string, string> gst = new Dictionary<string, string>();
            gst.Add("GuestName", "Jerry");
            
            newSettings.Add(app);
            newSettings.Add(sec);
            newSettings.Add(usr);
            // newSettings.Add(gst);

            // List<string> model = SettingsHelper.SetAllSettings(settings, newSettings);
            List<string> model = SettingsHelper.SetAllSettings(writableSettings, newSettings);

            return View(model);
        }
    }
}
using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication2.Models;
using System.Net.Http;
using WebApplication2.CommunicationProtocols;
using System.Linq;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ButtonPress(string button)
        {
            // cycle through
            // mute
            // on/off
            // sources

            // For some you only need one button, writing multiple if elses would be a waste of valueable readability resources and much other stuff.
            if ((new[] { "muteValue", "powerValue" }.Contains(button)))
            {
                button = new ByteMessageSender(hexStringCommand: ByteTVCommandsMessageModel.KnownTVCommands[button]).Result;
            }

            //JSONMessageSender jSONMessageSender = new JSONMessageSender(JSONMessage:JSONTVCommandsMessageModel.KnownTVCommands[button]);
            ByteMessageSender byteMessageSender = new ByteMessageSender(hexStringCommand: ByteTVCommandsMessageModel.KnownTVCommands[button]);

            //else 
            //{
            //JSONMessageSender jSONMessageSender = new JSONMessageSender(JSONMessage: JSONTVCommandsMessageModel.KnownTVCommands[button]);


            //}
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
